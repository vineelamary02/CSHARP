using System;
class SwitchDemo
{
static void Main()
{
Console.Write("Enter student no(1-5):");
int sno = int.Parse(Console.ReadLine());

switch(sno)
{
case 1:
Console.WriteLine("student 1");
break;
case 2:
Console.WriteLine("student 2");
break;
case 3:
Console.WriteLine("student 3");
break;
case 4:
Console.WriteLine("student 4");
break;
case 5:
Console.WriteLine("student 5");
break;
default:
Console.WriteLine("no student exist with the given number");
break;
}
}
}