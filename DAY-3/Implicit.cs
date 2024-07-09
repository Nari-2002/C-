using System;
class Implicit{
	static void Main(){
		Console.Write("Enter an Integer:");
		int a=int.Parse(Console.ReadLine());
		Console.WriteLine("After widening values are:");
		long b=a;
		Console.WriteLine("Long value: {0}",b);
		float c=a;
		Console.WriteLine("Float value: {0}",c);
		double d=a;
		Console.WriteLine("Double value:{0}",d);
		
}
}