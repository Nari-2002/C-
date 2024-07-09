using System;
class MissNum{
	static void Main(){
		Console.Write("Enter Array:");
		string[] s=Console.ReadLine().Split(' ');
		int[] a=new int[s.Length];
		int ind=0;
		foreach(string x in s){
			a[ind++]=int.Parse(x);
		}
		

		for(int i=0;i<a.Length-1;i++){
			if(a[i]+1!=a[i+1]){
				Console.WriteLine("Miss:"+(a[i]+1));
			}
		}
	}
}
