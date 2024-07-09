using System;

class Transpose
{
    static void Main()
    {
        Console.Write("Enter number of rows: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] a = new int[rows, cols];

        for(int i = 0; i < rows; i++)
        {
            string[] input = Console.ReadLine().Split(' ');
            for(int j = 0; j < cols; j++)
            {
                a[i, j] = int.Parse(input[j]);
            }
        }

        int[,] t = new int[cols, rows];
        for(int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                t[j, i] = a[i, j];
            }
        }
	Console.WriteLine("Transpose is");
        for(int i = 0; i < cols; i++)
        {
            for(int j = 0; j < rows; j++)
            {
                Console.Write(t[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
