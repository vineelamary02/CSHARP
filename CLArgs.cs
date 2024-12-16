using System;
class AddParams
{
static void Main(String[] args)
{
double Sum=0;
foreach(string str in args)
Sum = Sum+ double.Parse(str);
Console.WriteLine($"sum of given{args.Length} no is :{Sum}");
}
}