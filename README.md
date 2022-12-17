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


