using System;
class CallByRef{
	public void Show(ref int val){
		val+=5;
		Console.WriteLine(val);
	}
	static void Main(){
		
		CallByRef c=new CallByRef();
		int val=10;
		Console.WriteLine("value befor"+val);
		c.Show(ref val);
		Console.WriteLine("value after"+val);
		
	}
}