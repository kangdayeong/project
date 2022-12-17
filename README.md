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
class BooleanConstantApp {
public static void Main() {
Console.WriteLine("TRUE OR TRUE = " + (true || true));
Console.WriteLine("TRUE OR FALSE = " + (true || false));
Console.WriteLine("FALSE OR TRUE = " + (false || true));
Console.WriteLine("FALSE OR FALSE = " + (false || false));
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
class IdentifierApp {
public static void Main() {
int MyVar=1, myvar=2;
int @int=10, 변수=20;
Console.WriteLine("MyVar = " + MyVar + ", myvar = " + myvar);
Console.WriteLine("@int = " + @int + ", 변수 = " + 변수);
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
using System;
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
class GFG
{
// Main Method
public static void Main()
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
}
}
using System;
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
}
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

using System;
class LocalVariableApp {
static int x;
public static void Main() {
int x = (LocalVariableApp.x=2) * 2;
Console.WriteLine("static x = " + LocalVariableApp.x);
Console.WriteLine("local x = " + x);
}
}
