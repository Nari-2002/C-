using System;
class Test1{
    //protected int a=10;
    protected internal void SayHi(){
        Console.WriteLine("in Test1");
    }
}

class Test2{
    static void Main(){
        Console.WriteLine("in Test2");
        Test1 t = new Test1();
        t.SayHi();
       // Console.WriteLine("in Test2 =>"+t.a);
    }
}
            