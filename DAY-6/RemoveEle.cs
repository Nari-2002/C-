using System;
class RemoveEle{
static int[] RemoveElement(int[] a,int ele){
	int[] n=new int[a.Length-1];
	int i=0;
	foreach(int x in a){
	if(x!=ele){
		n[i++]=x;
	}
	}
	return n;
	
}

static void Main(){
int[] a={1,2,3,4};
int[] b=RemoveEle.RemoveElement(a,3);
foreach(int x in b){
	Console.WriteLine(x);
}
}
}