using System;
class JumpStatments
{
static void Main()
{

		/*goto xxx;
		Console.WriteLine("Hello world.");
		xxx:
		Console.WriteLine("Goto called.");*/

		Console.WriteLine("Enter a un-signed integer value:");
		bool Status = uint.TryParse(Console.ReadLine(), out uint x);

		if (Status == false)
		{
			Console.WriteLine("Please enter un-signed intergers only.");
			return;
		}
			if(x==0 || x==1)
		{
			Console.WriteLine("Please enter the value that is greater than 1");
			return ;
		}

		for(uint i=1;  i<=10; i++)
			Console.WriteLine($"{x} * {i} = {x*i}");

}
}