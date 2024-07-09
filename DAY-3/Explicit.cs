using System;
class Explicit{
	static void Main(){
		Console.Write("Enter an Decimal:");
		double a=double.Parse(Console.ReadLine());
		Console.WriteLine("After narrowing values are:");
		float b=(float)a;
		Console.WriteLine("Float value: {0}",b);
		long c=(long)a;
		Console.WriteLine("Long value: {0}",c);
		int d=(int)a;
		Console.WriteLine("Int value:{0}",d);
		
}
}