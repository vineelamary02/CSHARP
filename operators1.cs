using System;
class Opertors 
{
static void Main()
{
Console.WriteLine(sizeof (bool));     //sizeof
Console.WriteLine(sizeof (char));
Console.WriteLine(sizeof (int));
Console.WriteLine(sizeof (double));

		Console.WriteLine(typeof(bool));    //typeof
		Console.WriteLine(typeof(char));
		Console.WriteLine(typeof(int));
		Console.WriteLine(typeof(double));

		double d = 31.56;
		object obj = d;
		if (obj is double)               //is	
			Console.WriteLine("obj contains a value of type double");
		else
			Console.WriteLine("obj contains a value of type unknown");


		object o = "Hello world";
		string s1 = Convert.ToString(o);
		string s2 = o as string;           //as


		int i = 100;
		Console.WriteLine(i == 100 ? "Hello" : "Hii");     //terinary operator


		string country1 = null, country2 = null, country3 = "India";
		Console.WriteLine(country1 ?? country2 ?? country3);
	}
}