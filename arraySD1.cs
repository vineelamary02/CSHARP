using System;
class Array2
{
static void Main()
{
int[] arr= {54,64,75,93,25,78,83,36,68,35,85,356,25,35};

for(int i=0; i<arr.Length;i++)
Console.Write(arr[i]+ " ");
Console.WriteLine();

		Array.Sort(arr);
		foreach(int i in arr)
			Console.Write(i + " ");       //accending order
		Console.WriteLine();

		Array.Reverse(arr);
		foreach (int i in arr)
			Console.Write(i + " ");       //decending order
		Console.WriteLine();

int[] brr = new int[12];
		Array.Copy(arr, brr, 7);
		foreach (int i in brr)
			Console.Write(i + " ");       
		Console.WriteLine();

	}
}