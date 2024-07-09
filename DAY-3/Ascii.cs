using System;
class Ascii{
	static void Main(){
		Console.Write("Enter a Short value:");
		int a=int.Parse(Console.ReadLine());
		Console.WriteLine("Original short value: "+a);
		Console.Write("Converted char value:"+(char)a);
		
}
}