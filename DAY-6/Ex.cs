using System;
class ConsEx{
	
	int tenth;
	ConsEx(int tenth){
		this.tenth=tenth;
	
	}
	ConsEx(ConsEx c){
	 	this.tenth=c.tenth;
	}
	void Display(){
	Console.WriteLine(tenth);
	}
			
		static void Main(){
		ConsEx c=new ConsEx(98);
		ConsEx c1=new ConsEx(89);
		c.Display();
		c1.Display();
		
		
	}
}