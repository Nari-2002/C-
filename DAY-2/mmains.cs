using System;
class Main1{
	static void Main(){
		Console.WriteLine("Main1");
	}
}
class Main2{
	static void Main(){
		Console.WriteLine("Main2");
	}
}

/*mmains.cs(3,14): error CS0017: Program 'd:\c#\DAY-2\mmains.exe' has more than one entry point defined: 'Main1.Main()'.
        Compile with /main to specify the type that contains the entry point.
mmains.cs(8,14): error CS0017: Program 'd:\c#\DAY-2\mmains.exe' has more than one entry point defined: 'Main2.Main()'.
        Compile with /main to specify the type that contains the entry point.*/