using System;
class ArrayFunc{
static void SumArr(int[] a){
	int sum=0;
	foreach(int i in a){
		sum+=i;
	}
	Console.WriteLine("sum is:"+sum);
}
static int[] SumEle(int[] a,int[] b){
	int[] c=new int[a.Length];
	for(int i=0;i<a.Length;i++){
		c[i]=a[i]+b[i];
	}
	return c;
}

static void Main(){
	int[] a={1,2,3};
	int[] b={1,2,3};
	SumArr(a);
	int[] c=SumEle(a,b);
	foreach(int i in c){
		Console.WriteLine(i);
	}
	
}

}