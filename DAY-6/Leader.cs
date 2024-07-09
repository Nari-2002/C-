using System;
using System.Linq;

class Leader1
{
  static bool Leader(int[] a,int ele){
	int i=Array.IndexOf(a,ele)+1;
	while(i<a.Length){
		if(a[i]>=ele){
		  return false;
		 
		}
		i++;
	}
	return true;
   }
  static void Main()
  {
        
        Console.WriteLine("Enter Elements:");
        string input = Console.ReadLine();
	int[] a = input.Split(' ').Select(int.Parse).ToArray();
	Console.WriteLine("Leaders are:");
	for(int i=0;i<a.Length;i++){
		if(Leader1.Leader(a,a[i])){
			Console.Write(a[i]+" ");
		}
	}
     }
}
