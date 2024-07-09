using System;
class Task4{
	int a =10;
	static int b=90;
	const int c=11;
	static void Main(){
		Task4 t=new Task4();
		Console.WriteLine(t.a+Task4.b+c);
}
}