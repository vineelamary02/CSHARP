using System;
class IfDemo
{
static void Main()
{
Console.WriteLine("Enter 1st num:");
double d1= double.Parse(Console.ReadLine());
Console.WriteLine("Enter 2nd num:");
double d2=double.Parse(Console.ReadLine());

if(d1>d2)
Console.WriteLine("1st num is greater than 2nd num:");
else if(d1<d2)
Console.WriteLine("2nd num is greater than 1st num:");
else
Console.WriteLine("both numbers are equal:");
}
}