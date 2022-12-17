# project
// 기본 자료형을 바이트 배열로 변환 (little-endian 형식 )
byte[] boolBytes = BitConverter.GetBytes(true);
byte[] shortBytes = BitConverter.GetBytes((short)32000);
byte[] intBytes = BitConverter.GetBytes(1652300);
// 바이트 배열을 원래 기본 형으로 복원
bool boolResult = BitConverter.ToBoolean(boolBytes, 0);
short shortResult = BitConverter.ToInt16(shortBytes, 0);
int intResult = BitConverter.ToInt32(intBytes, 0);
// 바이트 배열을 16진수 문자열로 출력 (little-endian 형식 )
Console.WriteLine(BitConverter.ToString(boolBytes));
Console.WriteLine(BitConverter.ToString(shortBytes));
Console.WriteLine(BitConverter.ToString(intBytes));

DateTime dt = DateTime.Now;
Console.WriteLine("오늘은 {0}년 {1}월 {2}일 ({3})이며",
dt.Year, dt.Month, dt.Day, dt.DayOfWeek);
Console.WriteLine("현재는 {0}시 {1}분 {2}초 입니다.",
dt.Hour, dt.Minute, dt.Day, dt.Second);
using System;
using System.Globalization; // CultureInfo Class
namespace Standard_format_string
{
class Program
{
static void Main(string[] args)
{
/* real value */
double value1 = -12345.6789;
// Gets a NumberFormatInfo associated with the en-US culture.
NumberFormatInfo nfi = new CultureInfo("en-US", false).NumberFormat;
Console.WriteLine(value1.ToString("C", nfi));
Console.WriteLine(value1.ToString("C3", nfi));
nfi.NumberDecimalDigits = 0;
nfi.CurrencyNegativePattern = 1; // 0==> negative sign =(), 1==> negative = -
Console.WriteLine(value1.ToString("C", nfi));
Console.WriteLine(value1.ToString("C3",nfi));
nfi = new CultureInfo("ko-KR", false).NumberFormat;
nfi.NumberDecimalDigits = 2;
double value2 = -123.456;
Console.WriteLine(value2.ToString("C", nfi));
Console.WriteLine(value2.ToString("C3", nfi));
Console.WriteLine("value2={0,10:C}", value2);
Console.WriteLine("value2={0,10:C3}", value2);
/* integer value */
Int64 myInt1 = -1234;
Console.WriteLine("myInt1={0,10:C}", myInt1);
Console.WriteLine("myInt1={0,10:C3}", myInt1);
NumberFormatInfo nfi2 = new CultureInfo("en-US", false).NumberFormat;
// Displays a negative value with the default number of decimal digits (2).
Int64 myInt = -1234;
Console.WriteLine(myInt.ToString("C", nfi2));
nfi2.CurrencyDecimalDigits = 4;
Console.WriteLine(myInt.ToString("C", nfi2));
}
}
}
using System;
namespace N_format_output
{
class Program
{
static void Main(string[] args)
{
double dblValue = -12445.6789;
Console.WriteLine(dblValue.ToString("N"));
// Displays -12,445.68
Console.WriteLine(dblValue.ToString("N1"));
// Displays -12 445,7
int intValue = 123456789;
Console.WriteLine(intValue.ToString("N1"));
// Displays 123,456,789.0
}
}
}
using System;
namespace G_format_output
{
class Program
{
static void Main(string[] args)
{
double number;
number = 12345.6789;
Console.WriteLine(number.ToString("G"));
// Displays 12345.6789
Console.WriteLine(number.ToString("G"));
// Displays 12345,6789
Console.WriteLine(number.ToString("G7"));
// Displays 12345.68
number = .0000023;
Console.WriteLine(number.ToString("G"));
// Displays 2.3E-06
Console.WriteLine(number.ToString("G"));
// Displays 2,3E-06
number = .0023;
Console.WriteLine(number.ToString("G"));
// Displays 0.0023
}
}
}
using System;
namespace D_format_output
{
class Program
{
static void Main(string[] args)
{
int value;
value = 12345;
Console.WriteLine(value.ToString("D"));
// Displays 12345
Console.WriteLine(value.ToString("D8"));
// Displays 00012345
value = -12345;
Console.WriteLine(value.ToString("D"));
// Displays -12345
Console.WriteLine(value.ToString("D8"));
// Displays -00012345
}
}
using System;
class RealConstantApp {
public static void Main() {
float f1=1.414F, f2=0.1414e01f;
double d=0.1414E1;
Console.WriteLine("f1 = " + f1 + ", f2 = " + f2 + ", d = " + d);
if (f1 == f2) Console.WriteLine("Yes");
else Console.WriteLine("No");
}
}
using System;
public class Example
{
public static void Main()
{
string[] names = { "Adam", "Bridgette", "Carla", "Daniel", "Ebenezer", "Francine", "George" };
decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80, 16.75m };
Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
for (int ctr = 0; ctr < names.Length; ctr++)
Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);
}
}
using System;
class IntTypeApp {
public static void Main() {
int i = 1000000;
Console.WriteLine(i * i);
long l = i;
Console.WriteLine(l * l);
}
}
using System;
class IfStApp {
public static void Main() {
int n;
Console.Write("Enter a number = ");
n = Console.Read() - '0';
if (n % 2 == 0)
Console.WriteLine(n + " is an even number.");
if (n % 2 != 0)
Console.WriteLine(n + " is an odd number.");
}
}
sing System;
class GFG
{
// Main Method
public static void Main()
{
int c = 0;
Console.WriteLine("The series is:");
for (int i = 1; i < 10; i++)
{
c = c + i;
Console.Write(c + " ");
}
Console.WriteLine("\npress any key to exit the process...");
// basic use of "Console.ReadKey()" method
Console.ReadKey();
}
}
using System;
class Example
{
static void Main()
{
const int July = 7;
const int Feb = 2;
int daysInJuly = System.DateTime.DaysInMonth(2001, July);
Console.WriteLine(daysInJuly);
// daysInFeb gets 28 because the year 1998 was not a leap year.
int daysInFeb = System.DateTime.DaysInMonth(1998, Feb);
Console.WriteLine(daysInFeb);
// daysInFebLeap gets 29 because the year 1996 was a leap year.
int daysInFebLeap = System.DateTime.DaysInMonth(1996, Feb);
Console.WriteLine(daysInFebLeap);

string[] array1 = new string[3]{ "안녕", "Hello", "Halo" };
string[] array2 = new string[] { "안녕", "Hello", "Halo" };
string[] array3 = { "안녕", "Hello", "Halo" };
using System;
class FormattedOutputApp {
public static void Main() {
Console.WriteLine("1) {0,-5},{1,5},{2,5}", 1.2, 1.2, 123.45);
double d = Math.PI;
Console.WriteLine("2) {0}", d);
Console.WriteLine("3) {0:C}", d);
Console.WriteLine("4) {0:E}", d);
Console.WriteLine("5) {0:F}", d);
Console.WriteLine("6) {0:G}", d);
Console.WriteLine("7) {0:P}", d);
Console.WriteLine("8) {0:R}", d);
Console.WriteLine("9) {0:X}", 255);
}
}
using System;
class CompoundSt {
public static void Main(string[] args) {
int n;
Console.Write("Enter one digit = ");
n = Console.Read() - '0';
if (n < 0)
Console.WriteLine("Negative number !");
else {
Console.WriteLine(n + " squared is " + (n*n));
Console.WriteLine(n + " cubed is " + (n*n*n));
}
}
}
.
using System;
class ArrayTypeApp {
public static void Main() {
int[] ia = new int[3];
int[] ib = {1, 2, 3};
// int[] ib = new int[] {1, 2, 3} 같은 의미이다
int i;
for (i = 0; i < ia.Length; i++)
ia[i] = ib[i];
for (i = 0; i < ia.Length; i++)
Console.Write(ia[i] + " ");
Console.WriteLine();
}
}
using System;
class AssignmentSt {
public static void Main(string[] args) {
short s; int i;
float f; double d;
s = 526;
d = f = i = s; // 맨 우측에서 좌로 할당 반복
Console.WriteLine("s = " + s + " i = " + i);
Console.WriteLine("f = " + f + " d = " + d);
}
}
using System;
public class Example
{
public static void Main()
{
string[] names = { "Adam", "Bridgette", "Carla", "Daniel", "Ebenezer", "Francine", "George" };
decimal[] hours = { 40, 6.667m, 40.39m, 82, 40.333m, 80, 16.75m };
Console.WriteLine("{0,-20} {1,5}\n", "Name", "Hours");
for (int ctr = 0; ctr < names.Length; ctr++)
Console.WriteLine("{0,-20} {1,5:N1}", names[ctr], hours[ctr]);
}
}
using System;
class ReadIntegerApp {
static int ReadInt() {
char ch;
int n=0;
while (!char.IsDigit(ch = (char)Console.Read()));
do {//
n = n*10 + (ch - '0');
ch = (char) Console.Read();
} while (char.IsDigit(ch)); // 숫자가 아닌 글자 입력 시 벗어남
return n;
}
public static void Main() {
Console.Write("*** input data : ");
Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt());
}
}
using System;
class BooleanConstantApp {
public static void Main() {
Console.WriteLine("TRUE OR TRUE = " + (true || true));
Console.WriteLine("TRUE OR FALSE = " + (true || false));
Console.WriteLine("FALSE OR TRUE = " + (false || true));
Console.WriteLine("FALSE OR FALSE = " + (false || false));
}
}
using System;
public class Program
{
public static void Main()
{
DataStore<string> cities = new DataStore<string>();
cities.AddOrUpdate(0, "Mumbai");
cities.AddOrUpdate(1, "Chicago");
cities.AddOrUpdate(2, "London");
Console.WriteLine(cities.GetData(100));
DataStore<int> empIds = new DataStore<int>();
empIds.AddOrUpdate(0, 50);
empIds.AddOrUpdate(1, 65);
empIds.AddOrUpdate(2, 89);
Console.WriteLine(empIds.GetData(0));
}
}
using System;
class IntegerConstantApp {
public static void Main() {
int i=255, h=0Xff;
long l=0XffL;
Console.WriteLine("i = {0}, h = {1}", i, h);
if (h == l) Console.WriteLine("Yes");
else Console.WriteLine("No");
}
}
using System;
enum Color {Red, Green, Blue};
class EnumTypeApp {
public static void Main() {
Color c = Color.Red;
c++;
int i = (int) c;
Console.WriteLine("Cardinality of " + c + " = " + i);
}
}
using System;
class IntTypeApp {
public static void Main() {
int i = 1000000;
Console.WriteLine(i * i);
long l = i;
Console.WriteLine(l * l);
}
}
using System;
class IfElseStApp {
public static void Main() {
int n;
Console.Write("Enter a number = ");
n = Console.Read() - '0';
if (n % 2 == 0)
Console.WriteLine(n + " is an even number.");
else
Console.WriteLine(n + " is an odd number.");
}
}

using System;
class PointerApp {
unsafe public static void Swap(int* px, int* py) {
int tmp = *px;
*px = *py;
*py = tmp;
}
public static void Main() {
int x = 1, y = 2;
Console.WriteLine("Before : x = " + x + ", y = " + y);
unsafe {
Swap(&x, &y);
}
Console.WriteLine(" After : x = " + x + ", y = " + y);
}
}
.
using System;
namespace standard_output_2
{
class Program
{
static void Main(string[] args)
{
double a = 3;
double b = 4;
Console.WriteLine("Pythagorean Theory of {0} and {1}:", a, b);
Console.WriteLine("Geometric ={0,12:F3}", Math.Sqrt(a * a + b * b));
Console.WriteLine("Geometric ={0:F3}", Math.Sqrt(a * a + b * b));//
double k = 3.4567;
Console.WriteLine("Percent Value = {0, 10:P3}", k);
Console.WriteLine("Percent Value = {0:P3}", k);
int value = 34561234;
Console.WriteLine("decimal Value = {0, -15:D}", value);
Console.WriteLine("decimal Value = {0:D10}", value);
}
}
}
using System;
class ArrayOfArrayApp {
public static void Main() {
int[][] arrayOfArray = new int[3][]; // declaration: 선언
int i, j;
for (i = 0; i < arrayOfArray.Length; i++) // creation: 생성
arrayOfArray[i] = new int[i+3]; // [3],[4],[5] 배열 생성
for (i = 0; i < arrayOfArray.Length; i++) // 초기화 사용
for (j = 0; j < arrayOfArray[i].Length; j++)
arrayOfArray[i][j] = i*arrayOfArray[i].Length + j; // I * 3 + j, i*4+j, I *5+j
for (I = 0; I < arrayOfArray.Length; i++) { // 내용 출력
for (j = 0; j < arrayOfArray[i].Length; j++)
Console.Write(" " + arrayOfArray[i][j]);
Console.WriteLine();
}
}
}

private Button[] bt = new Button[6] ; // 객체의 배열 선언
for (int i=0; I < bt.Length; i++)
{
bt[i] = new Button();
bt[i].Text = Convert.ToString(i);
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
class Student
{
//private data members
private int rollno;
private string name;
private int age;
//method to set student details
public void SetInfo(string name, int rollno, int age)
{
this.rollno = rollno;
this.age = age;
this.name = name;
}
//method to print student details
public void printInfo()
{
Console.WriteLine("Student Record: ");
Console.WriteLine("\tName : " + name);
Console.WriteLine("\tRollNo : " + rollno);
Console.WriteLine("\tAge : " + age);
}
}

class Program
{
static void Main()
{
//creating array of objects
Student[] S = new Student[2];
//initializing objects by default/inbuilt constructors
S[0] = new Student();
S[1] = new Student();
//reading and printing first object
S[0].SetInfo("Herry", 101, 25);
S[0].printInfo();
//reading and printing second object
S[1].SetInfo("Potter", 102, 27);
S[1].printInfo();
}
}
}

int n=1652300;
string text = n.ToString(); // 숫자를 문자열로 직렬화
int result = int.Parse(text); // 문자열로부터 숫자로 역직렬화
int result1 = Convert.ToInt32(text); // 문자열로부터 숫자로 역직렬화
using System;
class StringConstantApp {
public static void Main() {
char c = 'A';
int i;
i = c + 1;
Console.WriteLine("c = " + c + "\nnext c = " + (char)i);
Console.WriteLine("\"I am a string.\"");
Console.WriteLine(@"""I am a string.""");
}
}
using System;
class Program
{
static void Main(string[] args)
{
// method 1
int num = "a"[0];
char chr = "a"[0];
Console.WriteLine($"num = {num}");
Console.WriteLine($"chr = {chr}");
//method 2
string str1 = "abc";
chr = char.Parse("a");
char chr1 = (char)char.ConvertToUtf32(str1.Substring(0,1), 0);
num = char.ConvertToUtf32("a", 0); // return 97
Console.WriteLine($"num = {num}");
Console.WriteLine($"chr1 = {chr1}");
Console.WriteLine($"chr = {chr}");
}
}

using System;
class DivisionOperatorApp {
public static void Main() {
int i; double x;
i = 1 / 2;
x = 1 / 2;
Console.Write("i = " + i);
Console.WriteLine(", x = " + x);
i = (int) (1 / 2.0);
x = 1 / 2.0;
Console.Write("i = " + i);
Console.WriteLine(", x = " + x);
}
}//
using System;
class FormattedOutputApp {
public static void Main() {
Console.WriteLine("1) {0,-5},{1,5},{2,5}", 1.2, 1.2, 123.45);
double d = Math.PI;
Console.WriteLine("2) {0}", d);
Console.WriteLine("3) {0:C}", d);
Console.WriteLine("4) {0:E}", d);
Console.WriteLine("5) {0:F}", d);
Console.WriteLine("6) {0:G}", d);
Console.WriteLine("7) {0:P}", d);
Console.WriteLine("8) {0:R}", d);
Console.WriteLine("9) {0:X}", 255);
}
}

using System;
using System.Globalization; // CultureInfo Class
namespace Currency_IO_test
{
class Program
{
static void Main(string[] args)
{
double value = 12345.6789;
Console.WriteLine(value.ToString("C", CultureInfo.CurrentCulture));
Console.WriteLine(value.ToString("C3", CultureInfo.CurrentCulture));
Console.WriteLine("The current culture is now {0}",
CultureInfo.CurrentCulture.Name);
CultureInfo newUICulture;
newUICulture = new CultureInfo("en-US");
CultureInfo.CurrentUICulture = newUICulture;
Console.WriteLine(value.ToString("C", CultureInfo.CurrentUICulture));
Console.WriteLine(value.ToString("C3", CultureInfo.CurrentUICulture));
Console.WriteLine("The current UI culture is now {0}",
CultureInfo.CurrentUICulture.Name);
}
}
}
using System;
class RemainderOperatorApp {
public static void Main() {
int n, rem;
rem = 10 % 3;
n = 10 - (10 / 3 ) * 3;
Console.WriteLine("10 % 3 = " + rem);
Console.WriteLine("10-(10/3)*3 = " + n);
}
}

using System;
class RelationalOperatorsApp {
public static void Main() {
int x=3, y=5, z=7;
bool b1, b2;
b1 = x > y;
b2 = x < y && y < z;
Console.WriteLine("b1 = " + b1 + ", b2 = " + b2);
b1 = x <= y;
b2 = x >= y == y >= x;
Console.WriteLine("b1 = " + b1 + ", b2 = " + b2);
}
}

using System;
class LogicalOperatorApp {
public static void Main() {
Console.WriteLine(“TRUE AND TRUE = " + (true && true));
Console.WriteLine(“TRUE AND FALSE = " + (true && false));
Console.WriteLine(“FALSE AND TRUE = " + (false && true));
Console.WriteLine(“FALSE AND FALSE = " + (false && false));
}
}


using System;
class LogicalOperatorApp {
public static void Main() {
int x=3, y=5, z=7;
bool b;
b = x < y && y < z;
Console.WriteLine("Result = " + b);
b = x == y || x < y && y > z;
Console.WriteLine("Result = " + b);
}
}
//
using System;
class IncDecOperatorsApp {
public static void Main() {
int x=3, y=5;
int a, b;
++x; --y;
Console.WriteLine("x = " + x + " , y = " + y);
a = (++x) + 1;
Console.WriteLine("x = " + x + " , a = " + a);
b = (y++) + 1;
Console.WriteLine("y = " + y + " , b = " + b);
}
}
using System;
namespace P_format_output
{
class Program
{
static void Main(string[] args)
{
double number = .2468013;
Console.WriteLine(number.ToString("P"));
// Displays 24.68 %
Console.WriteLine(number.ToString("P"));
// Displays 24,68%
Console.WriteLine(number.ToString("P1"));
// Displays 24.7 %
}
}
}
using System;
namespace string_interpolation_2
{
class Program
{
static void Main(string[] args)
{
double a = 3;
double b = 4;
Console.WriteLine($"Pythagorean Theory of {a} and {b}:");
Console.WriteLine($"Geometric ={Math.Sqrt(a*a + b * b), 12:F3}");
Console.WriteLine($"Geometric ={Math.Sqrt(a * a + b * b) :F3}");
}
}
}

using System;
class BitOperatorApp {
public static void Main() {
int x=9, y=3;
Console.WriteLine(x + " & " + y + " = " + (x&y));
Console.WriteLine(x + " | " + y + " = " + (x|y));
Console.WriteLine(x + " ^ " + y + " = " + (x^y));
Console.WriteLine("~10 = " + (~10));
}
}

using System;
class ShiftOperatorApp {
public static void Main() {
Console.WriteLine(" 10 << 2 = " + (10 << 2));
Console.WriteLine(" -9 << 2 = " + ((-9) << 2));
Console.WriteLine(" 10 >> 2 = " + (10 >> 2));
Console.WriteLine(" -9 >> 2 = " + ((-9) >> 2));
}
}

using System;
class ConditionalOperatorApp {
public static void Main() {
int a, b, c;
int m;
Console.Write("Enter three numbers : ");
a = Console.Read() - '0';
b = Console.Read() - '0';
c = Console.Read() - '0';
m = (a > b) ? a : b;
m = (m > c) ? m : c;
Console.WriteLine("The largest number = " + m);
}
}

using System;
class PrintTenItemApp {
public static void Main() {
int i, n=25;
for (i=1; i<=n; ++i)
Console.Write(i + ((i%10 == 0 || i==n) ? "\n" : " "));
}
}

using System;
class CompoundAssignmentApp {
public static void Main() {
int x, y=2;
x = 10; x += y; Console.Write("\t1. x = " + x + ",");
x = 10; x -= y; Console.Write("\t2. x = " + x + ",");
x = 10; x *= y; Console.Write("\t3. x = " + x + ",");
x = 10; x /= y; Console.Write("\t4. x = " + x + ",");
x = 10; x %= y; Console.WriteLine("\t5. x = " + x);
x = 10; x &= y; Console.Write("\t6. x = " + x + ",");
x = 10; x |= y; Console.Write("\t7. x = " + x + ",");
x = 10; x ^= y; Console.Write("\t8. x = " + x + ",");
x = 10; x <<= y; Console.Write("\t9. x = " + x + ",");
x = 10; x >>= y; Console.WriteLine("\t10. x = " + x);
}
}

using System;
class CastOperatorApp {
public static void Main() {
int i = 0Xffff;
short s;
s = (short) i;
Console.WriteLine("i = " + i);
Console.WriteLine("s = " + s);
}
}

using System;
public class IsAsOperatorApp {
static void IsOperator(object obj) {
Console.WriteLine(obj + " is int: " + (obj is int));
Console.WriteLine(obj + " is string: " +(obj is string));
}
static void AsOperator(object obj) {
Console.WriteLine(obj + " as string == null: " +
(obj as string == null));
}
public static void Main() {
IsOperator(10);
IsOperator("ABC");
AsOperator(10);
AsOperator("ABC");
}
}

using System;
using System.Reflection;
class Apple {
public int nSeeds = 0;
public void Ripen() { /* ... */ }
}
class TypeOfOperatorApp {
public static void Main() {
Type t = typeof(Apple);
string className = t.ToString();
MemberInfo[] allMembers = t.GetMembers();
Console.WriteLine("All " + className + " Members:");
foreach (MemberInfo member in allMembers) {
Console.WriteLine(member.ToString());
}
}
}

using System;
class ConversionTest
{
public static void Main()
{
string a = "31234";
int b = int.Parse(a); // 문자열 "31234"를 수 31234로 변환
float c = 22f / 7f;
double d = (double)c; // float형 변수 c를 double 형으로 변환
Console.WriteLine("string a : {0}",a);
Console.WriteLine("int b : {0}", b);
Console.WriteLine("float c : {0}", c);
Console.WriteLine("double a : {0}", d);
}
}

using System;
class BoxingUnboxingApp {
public static void Main() {
int foo = 526;
object bar = foo; // 박싱: foo is boxed to bar.
Console.WriteLine(bar);
try {
double d = (short)bar;
Console.WriteLine(d);
} catch (InvalidCastException e) {
Console.WriteLine(e + "Error");
}
}
}

using System;
class Program
{
public static void Main()
{
double? num1 = null;
double? num2 = 10.0;
if (num1.HasValue)
Console.WriteLine("num1 = " + num1.Value);
else
Console.WriteLine("num1 does not have value.");
if (num2.HasValue)
Console.WriteLine("num2 = " + num2.Value);
else
Console.WriteLine("num2 does not have value.");
}
}

public class SiteMemner
{
bool _getMarried;
public bool GetMarried
{
get { return _getMarried;}
set { _getMarried = value: }
}
}

public class SiteMemner
{
bool? _getMarried;
public bool? GetMarried
{
get { return _getMarried;}
set { _getMarried = value: }
}
}
using System;
class NestedIfApp {
public static void Main() {
int day;
Console.Write("Enter the day number 1 ~ 7 : ");
day = (int)Console.Read() - '0';
if(day == 1) Console.WriteLine("Sunday");
else if(day == 2) Console.WriteLine("Monday");
else if(day == 3) Console.WriteLine("Tuesday");
else if(day == 4) Console.WriteLine("Wednesday");
else if(day == 5) Console.WriteLine("Thursday");
else if(day == 6) Console.WriteLine("Friday");
else if(day == 7) Console.WriteLine("Saturday");
else Console.WriteLine("Illegal day");
}
}
  using System;
class GenericType<T> where T : SystemException {
private T value;//
public GenericType(T v) { value = v; }
override public String ToString() {
return "Type is " + value.GetType();
}
}
public class BoundedGenericApp {
public static void Main() {
GenericType<NullReferenceException> gNullEx =
new GenericType<NullReferenceException>(new NullReferenceException());
GenericType<IndexOutOfRangeException> gIndexEx =
new GenericType<IndexOutOfRangeException>(new IndexOutOfRangeException());
// GenericType<String> gString = new GenericType<String>("Error"); //에러
Console.WriteLine(gNullEx.ToString());
Console.WriteLine(gIndexEx.ToString());
}
}

using System;
class CalculatorApp {
public static void Main() {
int x, y, r=0;
char opr;
Console.Write("Enter an operator & two numbers = ");
opr = (char) Console.Read();
x = Console.Read() - '0';
y = Console.Read() - '0';
switch (opr) {
case '+' : r=x+y;
Console.WriteLine(x+" + "+y+" = "+r);
break;
case '-' : r=x-y;
Console.WriteLine(x+" - "+y+" = "+r);
break;
case '*' : r=x*y;
Console.WriteLine(x+" * "+y+" = "+r);
break;
case '/' : r=x/y;
Console.WriteLine(x+" / "+y+" = "+r);
break;
default : Console.WriteLine("Illegal operator ");
break;
}
}
}
using System;
class ForeachStAPP
{
public static void Main()
{
string[] color = { "red", "green", "blue" };
foreach (string s in color)
Console.WriteLine(s);
}
}
using System;
class IdentifierApp {
public static void Main() {
int MyVar=1, myvar=2;
int @int=10, 변수=20;
Console.WriteLine("MyVar = " + MyVar + ", myvar = " + myvar);
Console.WriteLine("@int = " + @int + ", 변수 = " + 변수);
}
}//
using System;
class IdentifierApp {
public static void Main() {
int MyVar=1, myvar=2;
int @int=10, 변수=20;
Console.WriteLine("MyVar = " + MyVar + ", myvar = " + myvar);
Console.WriteLine("@int = " + @int + ", 변수 = " + 변수);
}
}


using System;
class IdentifierApp {
public static void Main() {
int MyVar=1, myvar=2;
int @int=10, 변수=20;
Console.WriteLine("MyVar = " + MyVar + ", myvar = " + myvar);
Console.WriteLine("@int = " + @int + ", 변수 = " + 변수);
}
}

using System;
class SimpleIOApp {
public static void Main() {
int i; char c;
Console.Write("Enter a digit and a character = ");
i = Console.Read() - 48; // ‘0’ = 48 (문자 코드 값 )
c = (char)Console.Read(); // (char) : casting 연산자: int => char
Console.Write("i = " + i);
Console.WriteLine(", c = " + c);
}
}
using System;
namespace F_format_output
{
class Program
{
static void Main(string[] args)
{
int integerNumber;
integerNumber = 17843;
Console.WriteLine(integerNumber.ToString("F"));
// Displays 17843.00
integerNumber = -29541;
Console.WriteLine(integerNumber.ToString("F3"));
// Displays -29541.000
double doubleNumber;
doubleNumber = 18934.1879;
Console.WriteLine(doubleNumber.ToString("F"));
// Displays 18934.19
Console.WriteLine(doubleNumber.ToString("F0"));
// Displays 18934
doubleNumber = -1898300.1987;
Console.WriteLine(doubleNumber.ToString("F1"));
// Displays -1898300.2
Console.WriteLine(doubleNumber.ToString("F3"));
// Displays -1898300,199
}
}
}


using System;
class IdentifierApp {
public static void Main() {
int MyVar=1, myvar=2;
int @int=10, 변수=20;
Console.WriteLine("MyVar = " + MyVar + ", myvar = " + myvar);
Console.WriteLine("@int = " + @int + ", 변수 = " + 변수);
}
}
class UserErrException : ApplicationException // 예외 클래스 정의
{
public UserErrException(String s) : base(s) { } // 생성자
}
// …..
class UserClass {
// ………
if (val < 0) throw new UserErrException(“user exception message”);
}
using System
namespace ConsoleApp1
{
internal class Program
{
static void Main(string[] args)
{
int value = Console.Read();
Console.WriteLine("Read Result : {0}", value);
}
}
}
class TemplateClass<T>
{
T temp;
public void setT<U> (U t)
{
temp = t; // 오류 발생 지점
}
}
  #define CSHARP
using System;
using System.Diagnostics;
class ConditionalAttrApp {
[Conditional("CSHARP")]
public static void CsharpMethod() {
Console.WriteLine("In the CSharp Method ...");
}
[Conditional("JAVA")]
public static void JavaMethod() {
Console.WriteLine("In the Java Method ...");
}
public static void Main() {
ConditionalAttrApp.CsharpMethod();
ConditionalAttrApp.JavaMethod();
}
}

using System
namespace ConsoleApp1
{
internal class Program
{
static void Main(string[] args)
{
int value = Console.Read();
Console.WriteLine("Read Result : {0}", value);
}
}
}
using System;
using System.Globalization;
namespace E_format_output
{
class Program
{
static void Main(string[] args)
{
double value = 12345.6789;
Console.WriteLine(value.ToString("E"));
// Displays 1.234568E+004
Console.WriteLine(value.ToString("E10"));
// Displays 1.2345678900E+004
Console.WriteLine(value.ToString("e4"));
// Displays 1.2346e+004
}
}
}
  class DataStore<T>
{
private T[] _data = new T[10];
public void AddOrUpdate(int index, T item)
{
if (index >= 0 && index < 10)
_data[index] = item;
}
public T GetData(int index)
{
if (index >= 0 && index < 10)
return _data[index];
else
return default(T);
}
}
using System;
public class MyAttrAttribute: Attribute { // 속성 클래스
public MyAttrAttribute(string message) { // 생성자
this.message = message;
}
private string message; // 필드 : 멤버 변수
public string Message { // 프로퍼티
get { return message; }
}
}
[MyAttr("This is Attribute test.")]
class MyAttributeApp {
public static void Main() {
Type type = typeof(MyAttributeApp);
object[] arr = type.GetCustomAttributes(typeof(MyAttrAttribute), true);
if (arr.Length == 0)
Console.WriteLine("This class has no custom attrs.");
else {
MyAttrAttribute ma = (MyAttrAttribute) arr[0];
Console.WriteLine(ma.Message);
}
}
}
using System;
namespace ConsoleApp1
{
internal class Program
{
static void Main(string[] args)
{
string name = Console.ReadLine();
Console.WriteLine("ReadLine Result : {0}", name);
}
}
}
public class GenericClassExample {
public static void Main() {
SimpleGeneric<Int32> gInteger = new SimpleGeneric<Int32>(10);
SimpleGeneric<Double> gDouble = new SimpleGeneric<Double>(10);
gInteger.Add(1, 2);
gInteger.Add(1, 2, 3, 4, 5, 6, 7);
gInteger.Add(0);
gInteger.Print();
gDouble.Add(10.0, 20.0, 30.0);
gDouble.Print();
}
}
  using System;
class ObsoleteAttrApp {
[Obsolete("경고, Obsolete Method입니다.")]
public static void OldMethod() {
Console.WriteLine("In the Old Method ...");
}
public static void NormalMethod() {
Console.WriteLine("In the Normal Method ...");
}
public static void Main() {
ObsoleteAttrApp.OldMethod();
ObsoleteAttrApp.NormalMethod();
}
} 
using System;//
class ReadLineApp {
public static void Main() {
int time, hour, minute, second;
Console.WriteLine(“*** Enter an integral time : ”);
time = int.Parse(Console.ReadLine());
hour = time / 10000;
minute = time / 100 % 100;
second = time % 100;
Console.WriteLine(“*** Time is ” + hour + “:” + minute + “:” + second);
}
}
using System;
namespace ConsoleApp1
{
internal class Program
{
static void Main(string[] args)
{
while(true)
{
ConsoleKeyInfo name = Console.ReadKey();
Console.WriteLine("\n You Press : {0}", name.Key);
}
}
}
}
using System;
class LocalVariableApp {
static int x;
public static void Main() {
int x = (LocalVariableApp.x=2) * 2;
Console.WriteLine("static x = " + LocalVariableApp.x);
Console.WriteLine("local x = " + x);
}
}using System;
namespace Generic_operator
{
class Program
{
static void Main(string[] args)
{
Console.WriteLine("int 형의 Div = {0}", MyMyGenericOperation<int>.Div(4, 3));
Console.WriteLine("double 형의 Div = {0}", MyMyGenericOperation<double>.Div(4.0, 3.0));
}
}
public class MyMyGenericOperation<T>
{
public static double? Div(T a, T b)
{
if ( a is int)
return ((a as int?) / ( b as int?));
else
return ((a as double?) / (b as double?));
}
}
}
  using System;
class PropagateApp {
void Orange() {
int i = 25, j = 0;
i = i / j;
Console.WriteLine("End of Orange method");
}
void Apple() {
Orange();
Console.WriteLine("End of Apple method");
}
public static void Main() {
PropagateApp p = new PropagateApp();
try {
p.Apple();
} catch (ArithmeticException) {
Console.WriteLine("ArithmeticException is processed");
}
Console.WriteLine("End of Main");
}
} 
using System;
class DoWhileApp { // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
public static void Main() {
int n, i;
double h = 0.0;
Console.Write("Enter a number = ");
n = Console.Read() - '0';
i = 1;
do {
h = h + 1/(double)i;
i++;
} while (i <= n);
Console.WriteLine("n = " + n + ", h = " + h);
}
}
public class GenericInterfaceApp {
public static void Main() {
GenericClass<Int32> gInteger = new GenericClass<Int32>();
GenericClass<String> gString = new GenericClass<String>();
gInteger.SetValue(10);
gString.SetValue("Text");
Console.WriteLine(gInteger.GetValueType());
Console.WriteLine(gString.GetValueType());
}
}
using System;
class SwitchStApp {
public static void Main() {
Console.Write("Enter the day number 1 ~ 7 : ");
int day = Console.Read() –’0’;
switch(day) {
case 1 : Console.WriteLine("Sunday"); break;
case 2 : Console.WriteLine("Monday"); break;
case 3 : Console.WriteLine("Tuesday"); break;
case 4 : Console.WriteLine("Wednesday"); break;
case 5 : Console.WriteLine("Thursday"); break;
case 6 : Console.WriteLine("Friday"); break;
case 7 : Console.WriteLine("Saturday"); break;
default : Console.WriteLine("Illegal day"); break;
}
}
}

using System;
class WhileStApp { // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
public static void Main(){
int i, n;
double h = 0.0;
Console.Write("Enter a number = ");
n = Console.Read() - '0';
i = 1;
while(i <= n) {
h = h + 1/(double) i;
i++;
}
Console.WriteLine("n = {0}, h = {1}", n, h);
}
}
            using System;
public class Program
{
public static void Main()
{
DataStore<string> strStore = new DataStore<string>();
strStore.Data = "Hello World!";
//strStorage.Data = 123; // compile-time error
Console.WriteLine(strStore.Data);
DataStore<int> intStore = new DataStore<int>();
intStore.Data = 100;
//intStorage.Data = "Hello World!"; // compile-time error
Console.WriteLine(intStore.Data);
KeyValuePair<int, string> kvp1 = new KeyValuePair<int, string>();
kvp1.Key = 100;
kvp1.Value = "Hundred";
Console.WriteLine(kvp1.Key + ", " + kvp1.Value);
KeyValuePair<string, string> kvp2 = new KeyValuePair<string, string>();
kvp2.Key = "IT";
kvp2.Value = "Information Technology";
Console.WriteLine(kvp2.Key + ", " + kvp2.Value);
}
}
using System;
class SwitchWithString
{
static void Main(string[] args)
{
Console.Write("Enter the weekday (Sunday-Saturday) : ");
string day = Console.ReadLine();
switch (day)
{
case "Sunday": Console.WriteLine(1); break;
case "Monday": Console.WriteLine(2); break;
case "Tuesday": Console.WriteLine(3); break;
case "Wednesday": Console.WriteLine(4); break;
case "Thursday": Console.WriteLine(5); break;
case "Friday": Console.WriteLine(6); break;
case "Saturday": Console.WriteLine(7); break;
default: Console.WriteLine("Illegal day"); break;
}
}
}
  interface IGenericInterface<T> {
void SetValue(T x);
string GetValueType();
}
class GenericClass<T> : IGenericInterface<T> {
private T value;
public void SetValue(T x) {
value = x;
}
public String GetValueType(){
return value.GetType().ToString();
}
}
  using System;
using System.Collections.Generic;
namespace cnstraints
{
class GenericClass<T> where T : class
{
private readonly T _field;
public GenericClass(T value)
{
this._field = value;
}
public T genericMethod(T parameter)
{
Console.WriteLine($"The type of parameter we got is: {typeof(T)} and value is: {parameter}");
Console.WriteLine($"The return type of parameter is: {typeof(T)} and value is: {this._field}");
return this._field;
}
}
class Program
{
static void Main(string[] args)
{
GenericClass<string> myGeneric = new GenericClass<string>("Hello World");
myGeneric.genericMethod("string");
Console.ReadKey();
}
}
}
using System
namespace ConsoleApp1
{
internal class Program
{
static void Main(string[] args)
{
int value = Console.Read();
Console.WriteLine("Read Result : {0}", value);
}
}
}
using System;
class MyException : ApplicationException {
public int value;
public MyException() { } // 생성자
public MyException(string msg, int i) : base(msg) { // 생성자
value = i;
}
}
class MsgExceptionApp {
static void F(int k) {
if (k < 70 || k > 100)
throw new MyException();
}
static void G(int k) {
if (k > 200)
throw new MyException("Too Many", k);
if (k < 50)
throw new MyException("Too Less", k);
}
public static void Main() {
try {
F(50);
} catch (MyException e) {
Console.WriteLine(e.StackTrace);
}
try {
G(250);
} catch (MyException e) {
Console.WriteLine(e.Message);
Console.WriteLine(e.StackTrace);
Console.WriteLine("Data value is " + e.value + ".");
}
}
}
  using System;
using System.Collections.Generic;
public class Test1<T>
{
// public void Test1Method<T>(T x)
// class-level 과 method-level type parameter 일치 경고
public void Test1Method<U>(U x, T y)
{
Console.WriteLine("x={0}, y={1}", x, y);
}
}
public class Test2
{
public void Test2Method<T>(T x, T y)
{
Console.WriteLine("x={0}, y={1}", x, y);
}
}

using System;
class IfStApp {
public static void Main() {//
int n;
Console.Write("Enter a number = ");
n = Console.Read() - '0';
if (n % 2 == 0)
Console.WriteLine(n + " is an even number.");
if (n % 2 != 0)
Console.WriteLine(n + " is an odd number.");
}
}
using System;
class SimpleIOApp {
public static void Main() {
int i; char c;
Console.Write("Enter a digit and a character = ");
i = Console.Read() - 48; // ‘0’ =48
c = (char)Console.Read();
Console.Write("i = " + i);
Console.WriteLine(", c = " + c);
}
}
sing System;
class GFG
{
// Main Method
public static void Main()
{
int c = 0;
Console.WriteLine("The series is:");
for (int i = 1; i < 10; i++)
{
c = c + i;
Console.Write(c + " ");
}
Console.WriteLine("\npress any key to exit the process...");
// basic use of "Console.ReadKey()" method
Console.ReadKey();
}
}
                       using System;
class UserErrException : ApplicationException {
public UserErrException(string s) : base(s) {} // 생성자
}
class UserException {
public static void Main() {
try {
throw new UserErrException("throw a exception with a message");
}
catch (UserErrException e) {//
Console.WriteLine(e.Message);
}
}
}
using System;
class FinallyClauseApp {
static int count = 0;
public static void Main() {
while (true) {
try {
if (++count == 1) throw new Exception();
if (count == 3) break;
Console.WriteLine(count + ") No exception");
} catch (Exception) {
Console.WriteLine(count + ") Exception thrown");
} finally {
Console.WriteLine(count + ") in finally clause");
}
} // end while
Console.WriteLine("Main program ends");
}
}                        
using System;
class ContinueStApp {
public static void Main() {
int n, s, i;
Console.Write("Enter a number = ");
for (;;) {
n = Console.Read() - '0';
if (n == 0) break; // 0 입력 시 종료
else if (n < 0) continue; // 음의 수는 무시
for (s=0, i=1; i<=n; ++i)
s += i;
Console.WriteLine("n = " + n + ", sum = " + s);
}
Console.WriteLine("End of Main");
}
}
using System;
class GenericMethodApp {
static void Swap<DataType>(ref DataType x, ref DataType y) {
DataType temp;
temp = x; x = y; y = temp;
}
public static void Main() {
int a = 1, b = 2; double c = 1.5, d = 2.5;
Console.WriteLine("Before: a = {0}, b = {1}", a, b);
Swap<int>(ref a, ref b); // 정수형 변수로 호출
Console.WriteLine(" After: a = {0}, b = {1}", a, b);
Console.WriteLine("Before: c = {0}, d = {1}", c, d);
Swap<double>(ref c, ref d); // 실수형 변수로 호출
Console.WriteLine(" After: c = {0}, d = {1}", c, d);
}
}
  using System;
using System.Threading; // 반드시 포함 !!!
class SimpleThreadApp {
static void ThreadBody() { // --- ①
for (int i = 0; i < 5; i++) {
Console.WriteLine(DateTime.Now.Second + " : " + i);
Thread.Sleep(1000); // 1초 동안 스레드 실행을 멈추고 대기 상태
}
}
public static void Main() {
ThreadStart ts = new ThreadStart(ThreadBody); // --- ②
Thread t = new Thread(ts); // --- ③
Console.WriteLine("*** Start of Main");
t.Start(); // --- ④
Console.WriteLine("*** End of Main");
}
} 
using System;
class ReadIntegerApp {
static int ReadInt() {
char ch;
int n=0;
while (!char.IsDigit(ch = (char)Console.Read()));
do {
n = n*10 + (ch - '0');
ch = (char) Console.Read();
} while (char.IsDigit(ch)); // 숫자가 아닌 글자 입력 시 벗어남
return n;
}
public static void Main() {
Console.Write("*** input data : ");
Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt());
}//
}
  
  class DataStore<T>
{
public T Data { get; set; }
}
class KeyValuePair<TKey, TValue>
{
public TKey Key { get; set; }
public TValue Value { get; set; }
}
using System;
namespace litrals
{
class Literally
{
static void Main(string[] args)
{
int myDecimal = 28;
int myOctal = 034;
int myHex = 0X1C;
Console.WriteLine($"The variable {nameof(myDecimal)} has value: {myDecimal}");
Console.WriteLine($"The variable {nameof(myOctal)} has value: {myOctal}");
Console.WriteLine($"The variable {nameof(myHex)} has value: {myHex}");
Console.ReadKey(); ;
}
}
}
  using System;
using System.Threading;
class Test
{
static void Main()
{
// **** static method를 thread로 사용 예 ****
// (1). .NET 1.0 버전
// ==> ThreadStart delegate를 생성할 때, class 이름과 method 이름 사용
// (2). .NET 2.0 버전 이후
// ==> ThreadStart delegate를 명시적으로 생성할 필요가 없음
// ==> Thread 생성자에서 class 이름과 method 이름 사용
// ==> compiler가 알아서 올바른 delegate 선택
// (1). NET 1.0 버전 코드
ThreadStart threadDelegate = new ThreadStart(Work.DoWork);
Thread newThread = new Thread(threadDelegate);
newThread.Start();
// (2). NET 2.0 버전 이후 코드
// Thread newThread = new Thread(Work.DoWork);
// newThread.Start();
// ####### instance method를 thread로 사용 예 ###########
// (1). .NET 1.0 버전
// ==> ThreadStart delegate를 생성할 때, instance(object) 이름과 method 이름 사용
// (2). .NET 2.0 버전 이후
// ==> ThreadStart delegate를 명시적으로 생성할 필요가 없음
// ==> Thread 생성자에서 object 이름과 method 이름 사용
// ==> compiler가 알아서 올바른 delegate 선택
// (1). NET 1.0 버전 코드
Work w = new Work();
w.Data = 42;
threadDelegate = new ThreadStart(w.DoMoreWork);
newThread = new Thread(threadDelegate);
newThread.Start();
// (2). NET 2.0 버전 이후 코드
// Work w = new Work();
// w.Data = 42;
// newThread = new Thread(w.DoMoreWork);
// newThread.Start();
}
  using System;
using System.Threading;
class ThreadProperty {
public void ThreadBody() {
Thread myself = Thread.CurrentThread; // 실행중인 자신의 스레드 객체 반환
for (int i = 1; i <= 3; i++) {
Console.WriteLine("{0} is activated => {1}", myself.Name, i); // 스레드 이름
Thread.Sleep(1000); // 1초 지연
}
}
}
class ThreadPropertyApp {
public static void Main() {
ThreadProperty obj = new ThreadProperty();
ThreadStart ts = new ThreadStart(obj.ThreadBody);
Thread t1 = new Thread(ts);
Thread t2 = new Thread(ts);
t1.Name = "Apple"; t2.Name = "Orange";
t1.Start(); t2.Start();
}
}
                      using System;
using System.Threading;
class ThreadPriorityApp {
static void ThreadBody() {
Thread.Sleep(1000);
}
public static void Main() {
Thread t = new Thread(new ThreadStart(ThreadBody));
t.Start();
Console.WriteLine("Current Priority : " + t.Priority);
++t.Priority;
Console.WriteLine("Higher Priority : " + t.Priority);
}
} 
  using System;
class DivByZeroExceptionApp {
public static void Main() {
int i=1, j=0, k;
k = i/j;
}//
}
using System;
using System.Threading;
class ThreadJoin {
public int start;
public int perfectNumber;
public void ThreadBody() {
int sum;
for (int i = start; ; i++) {
sum = 0;
for (int j = 1; j <= i/2; j++)
if (i % j == 0) sum += j; // 약수 합
if (i == sum) {
perfectNumber = i;
break;
}
}
}
}
class ThreadJoinApp {
public static void Main() {
ThreadJoin obj = new ThreadJoin();
ThreadStart ts = new ThreadStart(obj.ThreadBody);
Thread t = new Thread(ts);
Console.Write("Enter a number : ");
obj.start = int.Parse(Console.ReadLine()); // 필드(start) 초기화
t.Start();
t.Join();
Console.WriteLine("The perfect number over {0} is {1}.",
obj.start, obj.perfectNumber);
}
}
                      
using System;
using System.Threading;
class ThreadState {
public void ThreadBody() {
while (true) { // ... infinite loop ... } }
}
class ThreadStateApp {
public static void Main() {
ThreadState obj = new ThreadState();
ThreadStart ts = new ThreadStart(obj.ThreadBody);
Thread t = new Thread(ts);
Console.WriteLine("Step 1: " + t.ThreadState);
t.Start(); Thread.Sleep(100);
Console.WriteLine("Step 2: " + t.ThreadState);
t.Suspend(); Thread.Sleep(100);
Console.WriteLine("Step 3: " + t.ThreadState);
t.Resume(); Thread.Sleep(100);
Console.WriteLine("Step 4: " + t.ThreadState);
t.Abort(); Thread.Sleep(100);
Console.WriteLine("Step 5: " + t.ThreadState);
}
using System;
namespace string_compare
{
class Program
{
static void Main(string[] args)
{
string a = "ABC";
string b = "ABCDE";
int c = String.Compare(a, b);
int c1 = String.Compare(b, a);
Console.WriteLine("a compate b => result, {0}, {1}", c, c1);
string d = "ABC";
string e = "abcd";
int f = String.Compare(d, e, true);
int f1 = String.Compare(e, d, true);
Console.WriteLine("d compate e => result, {0}, {1}", f, f1);
string d1 = "ABC";
string e1 = "abc";
int f2 = String.Compare(d1, e1, true);
int f3 = String.Compare(e1, d1, true);
Console.WriteLine("d1 compate e1 => result, {0}, {1}", f2, f3);
}
}
}
using System;
class ForeachStAPP
{
public static void Main()
{
string[] color = { "red", "green", "blue" };
foreach (string s in color)
Console.WriteLine(s);
}
}
                      using System;
using System.Threading;
namespace Thread_parameter_passing_2
{
class ThreadParam
{
public int Value1;
public int Value2;
}
class Program
{
static void Main(string[] args)
{
Thread t = new Thread(threadFunc);
ThreadParam param = new ThreadParam();
param.Value1 = 10;
param.Value2 = 20;
t.Start(param);
}
static void threadFunc(object initialValue)
{
ThreadParam value = (ThreadParam)initialValue; // downcasting after upcasting
Console.WriteLine("{0}, {1}", value.Value1, value.Value2);
}
}
}
using System;//
class GFG
{
// Main Method
public static void Main()//
{
// "DateTime" is a inbuilt class
// for date and time
DateTime d = DateTime.Now;
// print the system date and time
Console.WriteLine("System date: {0:d}\n" +
"System time: {0:t}", d);
Console.Write("Press 'E' to exit the process...");
// here it ask to press "E" to exit
while (Console.ReadKey().Key != ConsoleKey.E)
{
}
}
}
using System;
namespace standard_output_2
{
class Program
{
static void Main(string[] args)
{
double a = 3;
double b = 4;
Console.WriteLine("Pythagorean Theory of {0} and {1}:", a, b);
Console.WriteLine("Geometric ={0,12:F3}", Math.Sqrt(a * a + b * b));
Console.WriteLine("Geometric ={0:F3}", Math.Sqrt(a * a + b * b));
double k = 3.4567;
Console.WriteLine("Percent Value = {0, 10:P3}", k);
Console.WriteLine("Percent Value = {0:P3}", k);
int value = 34561234;
Console.WriteLine("decimal Value = {0, -15:D}", value);
Console.WriteLine("decimal Value = {0:D10}", value);
}
}//
using System;
class ReadIntegerApp {
static int ReadInt() {
char ch;
int n=0;
while (!char.IsDigit(ch = (char)Console.Read()));
do {
n = n*10 + (ch - '0');
ch = (char) Console.Read();
} while (char.IsDigit(ch)); // 숫자가 아닌 글자 입력 시 벗어남
return n;
}
public static void Main() {
Console.Write("*** input data : ");
Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt());
}
}
  using System;
using System.Threading;
class SchedulerApp {
static int interval;
static void ThreadBody() {
Thread myself = Thread.CurrentThread; // 현재 스레드 반환
Console.WriteLine("Starting Thread : " + myself.Name); // 스레드 이름
for (int i = 1 ; i <= 3 * interval ; i++) {
if( i % interval == 0)
Console.WriteLine(myself.Name + " : " + i);
}
Console.WriteLine("Ending Thread : " + myself.Name);
}
public static void Main() {
Console.Write("Interval value : ");
interval = int.Parse(Console.ReadLine());
Thread.CurrentThread.Name = "Main Thread"; // 스레드 이름 지정
//Thread.CurrentThread.Priority = ThreadPriority.Highest;
Thread worker = new Thread(new ThreadStart(ThreadBody));
worker.Name = "Worker Thread";
worker.Start();
ThreadBody(); // Main Thread에서 ThreadBody() 수행
}
}
  using System;
public class Program
{
public static void Main()
{
DataStore<string> cities = new DataStore<string>();
cities.AddOrUpdate(0, "Mumbai");
cities.AddOrUpdate(1, "Chicago");
cities.AddOrUpdate(2, "London");
Console.WriteLine(cities.GetData(100));
DataStore<int> empIds = new DataStore<int>();
empIds.AddOrUpdate(0, 50);
empIds.AddOrUpdate(1, 65);
empIds.AddOrUpdate(2, 89);
Console.WriteLine(empIds.GetData(0));
}
}
using System;
class JumpStApp {
public static void Main() {
int n, s, i;
for(;;) {
Console.Write("Enter a number : ");
n = Int32.Parse(Console.ReadLine());
if(n == 0) break;
else if(n < 0) continue;
for(s = 0, i = 1 ; i <= n ; ++i)
s = sum(s, i);
Console.WriteLine("n = {0}, sum = {1}", n, s);
}
Console.WriteLine("End of Main");
}
static int sum(int s, int i) {
return s + i;
}//
}//
  using System;
class SystemHandlerApp {
public static void Main() {
int[] vector = {1, 2, 3};
try {
Console.WriteLine("Here: 1");
vector[4] = 4;
Console.WriteLine("Here: 2");
} catch (IndexOutOfRangeException e) {
Console.WriteLine("System Exception is occurred !!!");
}
Console.WriteLine("Here: 3");
}
}

using System;
namespace X_format_output
{
class Program
{
static void Main(string[] args)
{
int value;
value = 0x2045e;
Console.WriteLine(value.ToString("x"));
// Displays 2045e
Console.WriteLine(value.ToString("X"));
// Displays 2045E
Console.WriteLine(value.ToString("X8"));
// Displays 0002045E
value = 123456789;
Console.WriteLine(value.ToString("X"));
// Displays 75BCD15
Console.WriteLine(value.ToString("X2"));
// Displays 75BCD15
}
}
}//
using System;//
class PrintMatrixApp {
public static void Main(string[] args) {
int[,] m = { { 1, 2, 3},
{ 4, 5, 6},
{ 7, 8, 9} };
for (int i = 0; i < 3; i++) {
for (int j = 0; j < 3; j++)
Console.Write(m[i,j] + " ");
Console.WriteLine(); // 마지막 줄바꿈
}
}//
}
  using System;
using System.Threading;
class Test
{
static void Main()
{
// **** static method를 thread로 사용 예 ****
// (1). .NET 1.0 버전
// ==> ThreadStart delegate를 생성할 때, class 이름과 method 이름 사용
// (2). .NET 2.0 버전 이후
// ==> ThreadStart delegate를 명시적으로 생성할 필요가 없음
// ==> Thread 생성자에서 class 이름과 method 이름 사용
// ==> compiler가 알아서 올바른 delegate 선택
// (1). NET 1.0 버전 코드
// ThreadStart threadDelegate = new ThreadStart(Work.DoWork);
// Thread newThread = new Thread(threadDelegate);
// newThread.Start();
// (2). NET 2.0 버전 이후 코드
Thread newThread = new Thread(Work.DoWork);
newThread.Start();
// ####### instance method를 thread로 사용 예 ###########
// (1). .NET 1.0 버전
// ==> ThreadStart delegate를 생성할 때, instance(object) 이름과 method 이름 사용
// (2). .NET 2.0 버전 이후
// ==> ThreadStart delegate를 명시적으로 생성할 필요가 없음
// ==> Thread 생성자에서 object 이름과 method 이름 사용
// ==> compiler가 알아서 올바른 delegate 선택
// (1). NET 1.0 버전 코드
// Work w = new Work();
// w.Data = 42;
// threadDelegate = new ThreadStart(w.DoMoreWork);
// newThread = new Thread(threadDelegate);
// newThread.Start();
// (2). NET 2.0 버전 이후 코드
Work w = new Work();
w.Data = 42;
newThread = new Thread(w.DoMoreWork);
newThread.Start();
}
}

using System;//
class ReadIntegerApp {
static int ReadInt() {
char ch;
int n=0;
while (!char.IsDigit(ch = (char)Console.Read()));
do {
n = n*10 + (ch - '0');
ch = (char) Console.Read();
} while (char.IsDigit(ch));
return n;
}
public static void Main() {
Console.Write("*** input data : ");
Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt());
}
}
using System;
class SimpleGeneric<T> {
private T[] values; // T 자료형의 배열
private int index;
public SimpleGeneric(int len) { // Constructor (생성자)
values = new T[len];
index = 0;
}
public void Add(params T[] args) {
foreach (T e in args)
values[index++] = e; // 삽입 후 index 증가
}
public void Print() {
foreach (T e in values)
Console.Write(e + " ");
Console.WriteLine();
}
using System;
class ReadIntegerApp {
static int ReadInt() {
char ch;
int n=0;
while (!char.IsDigit(ch = (char)Console.Read()));
do {
n = n*10 + (ch - '0');
ch = (char) Console.Read();
} while (char.IsDigit(ch)); // 숫자가 아닌 글자 입력 시 벗어남
return n;
}
public static void Main() {
Console.Write("*** input data : ");
Console.WriteLine("*** read data : " + ReadInt() + " " + ReadInt());
}//
}
using System;
using System.Numerics;
namespace Euler_25
{
class Program
{
static void Main(string[] args)
{
BigInteger l1 = 1;
BigInteger l2 = 1;
BigInteger current = l1 + l2;
while (current.ToString().Length < 1000)
{
l2 = l1;
l1 = current;
current = l1 + l2;
}
Console.WriteLine(current);
}
}
}
using System;
class BreakStApp { // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
public static void Main() {
int n, i;
double h = 0.0;
Console.Write("Enter a number = ");
n = Console.Read() - '0';
i = 1;
while (true) {
h = h + 1/(double) i;
if (++i > n) break;
}
Console.WriteLine(" n = " + n + ", h = " + h);
}
}
switch (value) {
case 0 : Console.WriteLine(“In Case 0\n”);
goto case 1;
case 1 : Console.WriteLine(“In Case 1\n”);
goto case 2;
case 2 : Console.WriteLine(“In Case 2\n”);
goto default;
default : Console.WriteLine(“In default\n”);
break;
}
///
using System;
class StringConstantApp {
public static void Main() {
char c = 'A';
int i;
i = c + 1;
Console.WriteLine("c = " + c + "\nnext c = " + (char)i);
Console.WriteLine("\"I am a string.\"");
Console.WriteLine(@"""I am a string.""");
}
}
using System;
class DoubleVsDecimalApp {
public static void Main() {
double d = 0d;
decimal m = 0m;
for (int i = 0; i < 1000; i++) {
d += 0.10d;
m += 0.10m;
}
Console.WriteLine("0.1d*1000 = " + d);
Console.WriteLine("0.1m*1000 = " + m);
}
}//
using System;
class ForStApp { // h(n) = 1 + 1/2 + 1/3 + ... + 1/n
public static void Main(string[] args) {
int i, n;
double h = 0.0;
Console.Write("Enter a number = ");
n = Console.Read() - '0';
for (i = 1; i <= n; ++i)
h = h + 1/(double) i;
Console.WriteLine("n = {0}, h = {1}", n, h);
}
}
using System;
class CompoundSt {
public static void Main(string[] args) {
int n;
Console.Write("Enter one digit = ");
n = Console.Read() - '0';
if (n < 0)
Console.WriteLine("Negative number !");
else {
Console.WriteLine(n + " squared is " + (n*n));
Console.WriteLine(n + " cubed is " + (n*n*n));
}
}
}
using System;
class FormattedOutputApp {
public static void Main() {
Console.WriteLine("1) {0,-5},{1,5},{2,5}", 1.2, 1.2, 123.45);
double d = Math.PI;
Console.WriteLine("2) {0}", d);
Console.WriteLine("3) {0:C}", d);
Console.WriteLine("4) {0:E}", d);
Console.WriteLine("5) {0:F}", d);
Console.WriteLine("6) {0:G}", d);
Console.WriteLine("7) {0:P}", d);
Console.WriteLine("8) {0:R}", d);
Console.WriteLine("9) {0:X}", 255);
}
}

using System;
namespace P_format_output
{
class Program
{
static void Main(string[] args)
{
double number = .2468013;
Console.WriteLine(number.ToString("P"));
// Displays 24.68 %
Console.WriteLine(number.ToString("P"));
// Displays 24,68%
Console.WriteLine(number.ToString("P1"));
// Displays 24.7 %
}
}
}//

using System;//
class OverflowApp {
public static void Main() {
int i, max = int.MaxValue; // 정수 최대값 지정 (overflow 생성 용도)
try {
Console.WriteLine(“Start of try statement”);
i = max +1; // default: don’t check Overflow.
Console.WriteLine(“After default overflow”);
unchecked {
i = max + 1; // don’t check Overflow intentionally.
}
Console.WriteLine(“After unchecked statement”);
checked {
i = max + 1; // check Overflow
}
Console.WriteLine(“After checked statement”);
} catch (OverflowException e) {
Console.WriteLine(“caught an OverflowException”);
}
}
}
//double a = 3;
double b = 4;
Console.WriteLine($"Area of the right triangle with legs of {a} and {b} is {0.5 * a * b} ");
using System;
class LocalVariableApp {
static int x;
public static void Main() {
int x = (LocalVariableApp.x=2) * 2;
Console.WriteLine("static x = " + LocalVariableApp.x);
Console.WriteLine("local x = " + x);
}
}
using System;//
using System.Numerics;
using System.Globalization;
class Demo//
{
static void Main()
{
double doubleVal = 0.91234582637;
string str = doubleVal.ToString("R", CultureInfo.InvariantCulture);
double resRound = double.Parse(str, CultureInfo.InvariantCulture);
// round-trip Double with 'R'
Console.WriteLine(doubleVal.Equals(resRound));//
}
}
using System;
class Program
{
static void Main(string[] args)
{
string a;
a = String.Format("{0}의 {1}", "C#", "그림책");
Console.WriteLine(a);
string b = "ABC";
string c = "ABCDE";
int d = String.Compare(b, c);
Console.WriteLine(d);
string e = "abc";
int f = String.Compare(b, e, true);
Console.WriteLine(f);
string g = "책갈피 군";
string h =g.Replace("군", "양");
Console.WriteLine(h);
string i = "ABCDE";
string j = i.Substring(1, 3);
Console.WriteLine(j);
string k = "ABC";
Console.WriteLine(k.Length);
string l = string.Empty;
Console.WriteLine(l);
string m = "ABCDEF";
int n = m.IndexOf('D');
Console.WriteLine(n);
string o = "I,Love,You";
string [] p = o.Split(',');
foreach (string s in p)
Console.WriteLine(s);
}
}
          using System;
class SystemrExThrowApp {
public static void Exp(int ptr) {
if (ptr == 0)
throw new NullReferenceException();
}
public static void Main() {
int i = 0;
// SystemExThrowApp.Exp(i);
Exp(i); // 동일 클래스의 static 메소드는 호출 시 클래스명 제외 가능
}
}
using System;
class UserExceptionOne : ApplicationException { }
class UserExceptionTwo : ApplicationException { }
class ExceptionHandlerApp {
static void method(int i) {
if (i == 1) throw new UserExceptionOne();
else throw new UserExceptionTwo();
}
public static void Main() {
try {
Console.WriteLine("Here: 1");
method(2);
Console.WriteLine("Here: 2");
} catch (UserExceptionOne o) {
Console.WriteLine("UserExceptionOne is occurred !!!");
} catch (UserExceptionTwo t) {
Console.WriteLine("UserExceptionTwo is occurred !!!");
}
Console.WriteLine("Here: 3");
}
}
          using System;
using System.Threading;
class ThreadProperty {
public void ThreadBody() {
Thread myself = Thread.CurrentThread; // 실행중인 자신의 스레드 객체 반환
lock(this) {
for (int i = 1; i <= 3; i++) {
Console.WriteLine("{0} is activated => {1}", myself.Name, i); // 스레드 이름
Thread.Sleep(1000); // 1초 지연
}
}
}
}
class ThreadPropertyApp {
public static void Main() {
ThreadProperty obj = new ThreadProperty();
ThreadStart ts = new ThreadStart(obj.ThreadBody);
Thread t1 = new Thread(ts);
Thread t2 = new Thread(ts);
t1.Name = "Apple"; t2.Name = "Orange";
t1.Start(); t2.Start();
}
}
using System;
using System.Threading;
class ThreadProperty {
public void ThreadBody() {
Thread myself = Thread.CurrentThread; // 실행중인 자신의 스레드 객체 반환
Monitor.Enter(this);
for (int i = 1; i <= 3; i++) {
Console.WriteLine(“{0} is activated => {1}”, myself.Name, i); // 스레드 이름
Thread.Sleep(1000); // 1초 지연
}
Monitor.Exit(this);
}
}
class ThreadPropertyApp {
public static void Main() {
ThreadProperty obj = new ThreadProperty();
ThreadStart ts = new ThreadStart(obj.ThreadBody);
Thread t1 = new Thread(ts);
Thread t2 = new Thread(ts);
t1.Name = "Apple"; t2.Name = "Orange";
t1.Start(); t2.Start();
}
}
private void radioButton4_CheckedChanged(object sender, EventArgs e) {
if (radioButton4.Checked)
// 리스트 뷰의 항목을 자세한 리스트 형태로 보여준다.
listView1.View = View.Details;
}
private void radioButton5_CheckedChanged(object sender, EventArgs e) {
if (radioButton5.Checked)
// 리스트 뷰의 항목을 타일 형태로 보여준다.
listView1.View = View.Tile;
}
private void listView1_Click(object sender, EventArgs e) {
foreach (ListViewItem item in listView1.SelectedItems) {
ListViewItem.ListViewSubItemCollection subItem = item.SubItems;
// 각 항목에 대한 부항목을 얻기 위해 SubItems 프로퍼티를 사용
label1.Text = subItem[0].Text + "의 국가번호는 " + subItem[1].Text + "입니다.";
}
}
private void Form1_Load(object sender, EventArgs e) {
listView1.BackColor = Color.Brown;
listView1.ForeColor = Color.Blue;
listView1.GridLines = true;
listView1.Size = new Size(450, 130); // 150 * 3= 450=width
listView1.View = View.Details;
listView1.FullRowSelect = true;
ColumnHeader columnHeader1 = new ColumnHeader();
columnHeader1.Text = "Student Name";
columnHeader1.TextAlign = HorizontalAlignment.Left;
columnHeader1.Width = 150;
ColumnHeader columnHeader2 = new ColumnHeader();
columnHeader2.Text = "Father Name";
columnHeader2.TextAlign = HorizontalAlignment.Center;
columnHeader2.Width = 150;
ColumnHeader columnHeader3 = new ColumnHeader();
columnHeader3.Text = " Student No";
columnHeader3.TextAlign = HorizontalAlignment.Right;
columnHeader3.Width = 150;
listView1.Columns.Add(columnHeader1);
listView1.Columns.Add(columnHeader2);
listView1.Columns.Add(columnHeader3);
} 
private void Button1_Click(object sender, EventArgs e) {
listView1.Items.Remove(listView1.SelectedItems[0]);
}
private void Button2_Click(object sender, EventArgs e) {
listView1.Items.Clear();
}
private void Button3_Click(object sender, EventArgs e) {
ListViewItem lv1 = new ListViewItem(textBox1.Text);
lv1.SubItems.Add(textBox2.Text);
lv1.SubItems.Add(textBox3.Text);
listView1.Items.Add(lv1);
textBox1.Text = "";
textBox2.Text = "";
textBox3.Text = "";
}
  using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics; // 추가
namespace WF_linklabel
{
public partial class Form1 : Form
{
public Form1()
{
InitializeComponent();
}
private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
Process.Start(linkLabel1.Text);
}
private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
Process.Start(linkLabel2.Text);
}
private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
{
Process.Start("Notepad.exe", linkLabel3.Text);
}
}
}
