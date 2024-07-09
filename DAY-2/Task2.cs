using System;
class Task2{
	int a=10,c=10;
	static int b=20,d=20;
	static void Main(){
		Task2 t=new Task2();
		Console.WriteLine(t.a+t.c);//instance
		Console.WriteLine(Task2.b-Task2.d);// static
		Console.WriteLine(Task2.b*t.a);//instance static

	}
	
}