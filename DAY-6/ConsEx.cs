using System;
class ConsEx{
	string marks;
	int tenth,inter,btech;
	ConsEx(int tenth){
		this.tenth=tenth;
	
	}
	ConsEx(ConsEx,int inter){
		this.tenth=tenth;
		this.inter=inter;
	
	}
	ConsEx(ConsEx,int btech){
		this.tenth=tenth;
		this.inter=inter;
		this.btech=btech;
	
	}
	void Display(){
		Console.WriteLine("tenth:"+tenth);
		Console.WriteLine("tenth:"+tenth+" inter:"+inter);
		Console.WriteLine("tenth:"+tenth+" inter:"+inter+" btech:"+btech);

	}
	
		static void Main(){
		ConsEx c=new ConsEx(98);
		ConsEx c1=new ConsEx(98,95);
		ConsEx c2=new ConsEx(98,95,90);
		c2.Display;

	}
}