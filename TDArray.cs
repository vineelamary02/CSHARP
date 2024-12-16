using System;
class TDArray
{
static void Main()
{
	int x = 0;
int[,] arr = new int[4,5];

Console.WriteLine("Rows:" + arr.GetLength(0));  //to find out the lenght of rows and coloums of cells
Console.WriteLine("Columns:" + arr.GetLength(1));
Console.WriteLine("Cells:" + arr.Length + "\n");   //to find out over all length of overall cells

		foreach (int i in arr)  //accessing the values of 2D Array by using foreach loop
			Console.Write(i + " ");
		Console.WriteLine("\n");

//Assigning values to 2D Array by using nested for loop

		for(int i=0;i<arr.GetLength(0);i++)
		{
			for (int j = 0; j < arr.GetLength(1); j++)
			{
				x += 5;
				arr[i, j] = x;
			}
		}

		for (int i=0; i<arr.GetLength(0); i++)  //acessing the values of  2D Array by using nested for loop
		{
			for(int j=0;j<arr.GetLength(1); j++)
				Console.Write(arr[i,j] + " ");
			Console.WriteLine();
		}
		Console.WriteLine();

// Assign values to 2D Array  at the time of declaration
		int[,] arr =
		{
			{11,12,13,14 },
			{12,13,14,15},                  
			{13,14,15,16},
			{14,15,16,17},
		};
}
}