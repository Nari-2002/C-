using System;

class Fib
{
    static int Fibseq(int n)
    {
        if (n == 0)
        {
            return 0;
        }
        else if (n == 1)
        {
            return 1;
        }
        else
        {
            return Fibseq(n - 1) + Fibseq(n - 2);
        }
    }

    static void Main()
    {
        Console.Write("Enter the range: ");
        int n = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Fibonacci Sequence (Iterative):");
        int f0 = 0;
        int f1 = 1;
        Console.Write(f0 + " " + f1 + " ");
        for (int i = 3; i <= n; i++)
        {
            int f2 = f1 + f0;
            Console.Write(f2 + " ");
            f0 = f1;
            f1 = f2;
        }
        Console.WriteLine();

        Console.WriteLine("Fibonacci Sequence (Recursive):");
        for (int i = 0; i < n; i++)
        {
            Console.Write(Fibseq(i) + " ");
        }
    }
}
