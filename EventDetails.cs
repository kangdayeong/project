using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace Calendar.NET
{
    public partial class EventDetails : Form
    {
        string _server = "localhost";
        int _port = 3306;
        string _database = "calendardb";
        string _id = "root";
        string _pw = "dy12121004?";
        string _connectionAddress = "";
        [CustomRecurringFunction("RehabDates", "Calculates which days I should be getting Rehab")]

        private IEvent _event;
        private IEvent _newEvent;

        public IEvent Event
        {
            get { return _event; }
            set
            {
                _event = value;
                FillValues();
            }
        }

        public IEvent NewEvent
        {
            get { return _newEvent; }
        }

        public EventDetails()
        {
            InitializeComponent();
            _connectionAddress = string.Format("Server={0};Port={1};Database={2};Uid={3};Pwd={4}", _server, _port, _database, _id, _pw);
        }

        private void EventDetailsLoad(object sender, EventArgs e)
        {
            String fisrtDay = _event.Date.ToString("yyyy/M/d");
            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    String People = "";
                    string selectCalendarDetail = ($"select * from 현장 where CalendarDay='{fisrtDay}';");
                    string selectPeopleName = ($"select * from 인원 where PeopleDay='{fisrtDay}';");

                    MySqlCommand command1 = new MySqlCommand(selectCalendarDetail, mysql);
                    MySqlDataReader table1 = command1.ExecuteReader();
                    while (table1.Read())
                    {
                        DetailTextBox.Text = table1["CalendarDetail"].ToString();
                    }
                    table1.Close();
                    MySqlCommand command2 = new MySqlCommand(selectPeopleName, mysql);
                    MySqlDataReader table2 = command2.ExecuteReader();
                    while (table2.Read())
                    {
                        People += table2["PeopleName"].ToString()+" ";
                    }
                    table2.Close();
                    InputPeopleName.Text = People;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void FillValues()
        {
            txtEventName.Text = _event.EventText;
            dtDate.Value = _event.Date;
            dtDate.CustomFormat = _event.IgnoreTimeComponent ? "yyyy/M/d" : "yyyy/M/d";//시간 찾기

            Text = char.ToUpper(_event.EventText[0]) + _event.EventText.Substring(1) + " Details";

            _newEvent = _event.Clone();
        }

        private void BtnOkClick(object sender, EventArgs e)
        {
            _newEvent.EventText = txtEventName.Text;
            _newEvent.Date = dtDate.Value;

            String fisrtDay = _event.Date.ToString("yyyy/M/d");
            String text = txtEventName.Text;
            String day = dtDate.Value.ToString("yyyy/M/d");
            String detail = DetailTextBox.Text;

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string diableSafe = "SET SQL_SAFE_UPDATES = 0";
                    string selectQuery = ($"update 현장 set CalendarField='{text}', CalendarDay='{day}', CalendarDetail='{detail}' where CalendarDay='{fisrtDay}';");
                    string ableSafe = "SET SQL_SAFE_UPDATES = 1";

                    MySqlCommand command1 = new MySqlCommand(diableSafe, mysql);
                    MySqlDataReader table1 = command1.ExecuteReader();
                    table1.Close();
                    MySqlCommand command2 = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table2 = command2.ExecuteReader();
                    table2.Close();
                    MySqlCommand command3 = new MySqlCommand(ableSafe, mysql);
                    MySqlDataReader table3 = command3.ExecuteReader();
                    table3.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            Close();
            DialogResult = DialogResult.OK;
        }

        private void BtnCancelClick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String day = dtDate.Value.ToString("yyyy/M/d");
            _newEvent.Date = Convert.ToDateTime("2020-01-01");
            DialogResult = DialogResult.OK;

            try
            {
                using (MySqlConnection mysql = new MySqlConnection(_connectionAddress))
                {
                    mysql.Open();
                    string diableSafe = "SET SQL_SAFE_UPDATES = 0";
                    string deletePeople = ($"update 인원 set PeopleDay= {0000-00-00} where PeopleDay='{day}';");
                    string selectQuery = ($"delete from 현장 where CalendarDay='{day}'");
                    string ableSafe = "SET SQL_SAFE_UPDATES = 1";

                    MySqlCommand command1 = new MySqlCommand(diableSafe, mysql);
                    MySqlDataReader table1 = command1.ExecuteReader();
                    table1.Close();
                    MySqlCommand command2 = new MySqlCommand(selectQuery, mysql);
                    MySqlDataReader table2 = command2.ExecuteReader();
                    table2.Close();
                    MySqlCommand command3 = new MySqlCommand(deletePeople, mysql);
                    MySqlDataReader table3 = command3.ExecuteReader();
                    table3.Close();
                    MySqlCommand command4 = new MySqlCommand(ableSafe, mysql);
                    MySqlDataReader table4 = command4.ExecuteReader();
                    table4.Close();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            Close();
        }
    }
}
