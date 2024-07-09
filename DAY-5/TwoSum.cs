using System;
class Twosum{
    static void Main(){
		Console.Write("Enter Array:");
		string[] s=Console.ReadLine().Split(' ');
		int[] a=new int[s.Length];
		int ind=0;
		foreach(string x in s){
			a[ind++]=int.Parse(x);
		}
        Console.Write("sum: ");
        int f=0;
        int sum=int.Parse(Console.ReadLine());
        for(int i=0;i<a.Length;i++){
            for(int j=i+1;j<a.Length;j++){
                if(a[j]+a[i]==sum){
                    f=1;
                    Console.Write(i+" "+j);
                    break;
                }
            }if(f==1){break;}
        }
		
	}
}