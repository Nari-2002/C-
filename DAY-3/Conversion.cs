using System;
class Convertion{
	static void Main(){
		Console.Write("Enter a Double Value:");
		double d=double.Parse(Console.ReadLine());
		Console.WriteLine("Original Value before Casting:"+d);
		short s=(short)d;
		Console.WriteLine("After Type Casting to short:"+s);
		int i=(int)d;
		Console.WriteLine("After Type Casting to int:"+i);
	}
}