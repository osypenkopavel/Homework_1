/*
Define several variables in your program (byte, short, int, long, bool, char, float, double, decimal, string)
and write to console the result of addition, subtraction, multiplication of several of them.
*/

byte value1 = 0;
short value2 = 10000;
int value3 = 35;
int value11 = 7;
long value4 = 923372036854775807;
bool value5 = true;
char value6 = 'k';
float value7 = 1.3F; 
double value8 = 1.23;
decimal value9= 2.5m; 
string value10 = "string";

Console.WriteLine(value1+value2);
Console.WriteLine(value9-Convert.ToDecimal(value7));
Console.WriteLine((value3/value11)*value2);

/*
Write to console result of several math functions:
-6*x^3+5*x^2-10*x+15
abs(x)*sin(x)
2*pi*x
max(x, y)
*/
int x = 5;
int y = 10;

var equation = -6*x^3+5*x^2-10*x+15;
var AbsSin = Math.Abs(x)*Math.Sin(x);
var pi = 2*Math.PI*x;
var max = Math.Max(x, y);

Console.WriteLine(equation);
Console.WriteLine(AbsSin);
Console.WriteLine(pi);
Console.WriteLine(max);

/*how many days passed from New Year. Result in console should look like this:
X days left to New Year
Y days passed from New Year
*/

DateTime date1 = new DateTime(2022,1,1);
DateTime date2 = new DateTime(2023,1,1);
DateTime today = DateTime.Today;
Console.WriteLine((date2-today).TotalDays+" "+"days left to New Year");
Console.WriteLine((today-date1).TotalDays+" "+"days passed from New Year");