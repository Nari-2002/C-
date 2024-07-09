using System;
class Task3{
	int a=10,c=10;
	static int b=20,d=20;
		void display(){
		Console.WriteLine(a+c);
		Console.WriteLine(b-d);
		
	}
	void display2(){
		a=11;
		//b=30;
		int b=30;

		Console.WriteLine(a+c);
		Console.WriteLine(b-d);
		
	}
	
	static void Main(){
		Task3 t=new Task3();
		t.display();
		t.display2();
		
	}
	
}