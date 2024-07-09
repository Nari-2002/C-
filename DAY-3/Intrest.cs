using System;
class Intrest{
	static void Main(){
		Console.Write("Enter the principal amount:");
		double p=double.Parse(Console.ReadLine());
		Console.Write("Enter the rate of interest (in percentage):");
		double r=double.Parse(Console.ReadLine());
		Console.Write("Enter the time (in years):");
		double t=double.Parse(Console.ReadLine());
		Console.WriteLine("Simple Interest: "+(p*t*r)/100);



}
}