using System;
using System.Linq;

class MinMax
{
    static int Min(int[] a){
	int min=a[0];
	int max=a[0];
	foreach(int i in a){
		if(i<min){
			min=i;
		}
	}
	return min;

    }
    static int Max(int[] a){
	int min=a[0];
	int max=a[0];
	foreach(int i in a){
		if(i>max){
			max=i;
		}
	}
	return max;

    }
    static void Main()
    {
        
        Console.Write("Enter the number of people: ");
        int numPeople = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the ages of each person:");
        string input = Console.ReadLine();
	int[] ages=new int[numPeople];
        ages = input.Split(' ').Select(int.Parse).ToArray();
        int maxAge = ages.Max();
        int minAge = ages.Min();
        Console.WriteLine("Maximum age:"+MinMax.Max(ages));
        Console.WriteLine("Minimum age:"+MinMax.Min(ages));
    }
}
