using System;
class CallBy{
	public void Show(int val){
		val+=5;
		Console.WriteLine(val);
	}
	static void Main(){
		int a=10;
		CallBy c=new CallBy();
		Console.WriteLine("value befor"+a);
		c.Show(a);
		Console.WriteLine("value after"+a);
		
	}
}