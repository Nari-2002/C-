using System;
class Pension{
	static void Main(){
		Console.Write("Enter your name:");
		string name=Console.ReadLine();
		Console.Write("Enter your age:");
		int age=int.Parse(Console.ReadLine());
		Console.Write("Enter your dob:");
		int dob=int.Parse(Console.ReadLine());
		string type;
		if(age<18){
			type="children";
		}
		else if(age>=18 && age<=65)
		{
			type="adult";
		}
		else{
			type="senior";
		}
		Console.WriteLine("Hello, {0}! You are {1} years old",name,age);
		Console.WriteLine("You were born in the year {0}.You are an {1}.",dob,type);
	}
}