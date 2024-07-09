using System;
class SingleEle{
    static void Main(){
		Console.Write("Enter Array:");
		string[] s=Console.ReadLine().Split(' ');
		int[] a=new int[s.Length];
		int ind=0;
		foreach(string x in s){
			a[ind++]=int.Parse(x);
		}
        int sing=0;
        foreach(int i in a){
            sing ^=i;
        }
        Console.Write(sing);
		
	}
}