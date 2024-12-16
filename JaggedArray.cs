using System;
class JaggedArray
{
	static void Main()
	{
		int[][] arr = new int[4][];    //declaration
		arr[0] = new int[5];      //initialzation of 1st row
		arr[1] = new int[8];            //initialzation of 2nd row
		arr[2] = new int[4];          //initialzation of 3rd row
		arr[3] = new int[7];            //initialzation of 4th row
		Console.Clear();
		//accessing values of jagged array by using nested foreach loop
		foreach(int[] iarr in arr)
		{
			foreach(int i in iarr)
				Console.Write(i + " ");
			Console.WriteLine("\n");
		}
		Console.WriteLine("--------------");
		//accessing values of jagged array by using for in foreach loop
		foreach (int[] iarr in arr)
		{
			for(int i = 0;i<iarr.Length;i++)
				Console.Write(iarr[i] + " ");
			Console.WriteLine("\n");
		}
		Console.WriteLine("--------------");

		//accessing values of jagged array by using for in nested for loop
		for(int i = 0;i<arr.GetLength(0);i++)
		{
			for(int j = 0; j < arr[i].Length;j++)
				Console.Write(arr[i][j] + " ");
			Console.WriteLine();
		}
		Console.WriteLine("--------------");

		//assigning values of jagged array by using for in nested for loop
		for (int i = 0; i < arr.GetLength(0); i++)
		{
			for (int j = 0; j < arr[i].Length; j++)
			{
				arr[i][j] = i + 1;
			}
				
		}
		Console.WriteLine("--------------");
		//accessing values of jagged array by using foreach in for loop
		for (int i = 0;i<arr.GetLength(0);i++)
		{
			foreach(int x  in arr[i])
				Console.Write(x + " ");
			Console.WriteLine();
		}
		Console.WriteLine("--------------");
		//assigning values of jagged array by using foreach loop
		foreach (int[] iarr in arr)
		{
			for (int i = 0; i < iarr.Length; i++)
			{
				iarr[i] = i + 1;
			}
		}
	}
}