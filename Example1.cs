using System;
class AddNums
{
static void Main()
{
Console.WriteLine("Enter 1st num:");
String s1= Console.ReadLine();             //implicit boxing
		int i = Convert.ToInt32(s1);         //explicit un-boxing

		Console.WriteLine("Enter 2st num:");
		String s2 = Console.ReadLine();         //implicit boxing
		int j = int.Parse(s2);               //explicit unboxing

		int k = i + j;
		Console.WriteLine($"sum of {i} & {j} is: {k}");
	}
}