using System;
class Nullable{
	static void Main(){
		int? a=30;
		Console.WriteLine(a);
		a=null;
		Console.WriteLine(a);
		int b=a??0;
		Console.WriteLine(b);
		int? c=null;
		int val=c.GetValueOrDefault();
		Console.WriteLine(val);
		

	}
	
}