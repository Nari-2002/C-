using System;

class Test1{
    protected int a=10;
    protected void SayHi(){
        Console.WriteLine("in Test1");
    }
}

class Test2 : Test1 {
    static void Main(){
        Console.WriteLine("in Test2");
        Test2 t = new Test2();
        t.SayHi();
        Console.WriteLine("in Test2 =>"+t.a);
    }
}
