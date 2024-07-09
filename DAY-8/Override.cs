using System;
class sample{
    public void diplay(){
        Console.WriteLine("sample");
    }
}
class Test:sample{
    public void diplay(){
        Console.WriteLine("test");
    }
    static void Main(){
        Test t1=new Test();
        t1.diplay();
    }
}