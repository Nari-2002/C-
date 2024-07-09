using System;
class ArrayEx
{	
	static void EvenPos(int[] a){
		Console.WriteLine("Even Pos:");
		for(int i=0;i<a.Length;i++){
		if((i+1)%2==0){			
			Console.Write(a[i]+" ");
		}
		}

	}
		static void Main(){
		Console.WriteLine("Enter size");
		int n=int.Parse(Console.ReadLine());
		int[] a1=new int[n];
		Console.WriteLine("enter elements:");
		for(int i=0;i<n;i++){
			a1[i]=int.Parse(Console.ReadLine());
			
		}
		Console.WriteLine("elements are:");
		foreach(int i in a1){
			
			Console.Write(i+" ");
		}
		for(int i=0;i<a1.Length;i++){
		for(int j=i+1;j<a1.Length;j++){
			if(a1[i]>a1[j]){
				int temp=a1[i];
				a1[i]=a1[j];
				a1[j]=temp;
			}
			
		}

	     }
		Console.WriteLine();
		foreach(int i in a1){
			
			Console.Write(i+" ");
		}
		
	}
}
