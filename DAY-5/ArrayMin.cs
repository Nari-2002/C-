using System;
class ArrayMin{
static void Main(){
	int[] a={1,2,3,45,32};
	int min=a[0];
	int max=a[0];
	foreach(int i in a){
		if(i<min){
			min=i;
		}
	}
	foreach(int i in a){
		if(i>max){
			max=i;
		}
	}
	Console.WriteLine("min: "+min);
	Console.WriteLine("max: "+max);

	}
}