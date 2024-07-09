using System;
class sample{
    public void diplay(){
        Console.WriteLine("sample");
    }
}
class sample1{
    public  void diplay(){
        Console.WriteLine("sample1");
    }
}
class Test:sample1{
    public void diplay(){
        base.diplay();
        Console.WriteLine("test");
    }
    
    static void Main(){
        Test t1=new Test();
        t1.diplay();
    }
}