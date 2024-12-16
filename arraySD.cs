using System;
class Array1
{
static void Main()
{
		int x = 0;
int[] arr = new int[6];
//accessing or printing the values of sd array by using for loop
for(int i=0; i<6; i++)
Console.Write(arr[i]);
//assigning values to the sd array by unsing for loop
for(int i=0; i<6;i++)
		{
			x += 10;
			arr[i] = x;
		}
//accessing or printing the values of sd array by using foreach loop
		foreach (int i in arr)
Console.Write(i+ " ");


	}
}