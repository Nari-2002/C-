using System;
interface I1{
    void Display();
}

class Sample:I1{
    public void Display(){
        Console.WriteLine("Sample");
    }
}
interface I2:I1{
    void Display1();
}
class Test:Sample,I2{
    public void Display(){
        Console.WriteLine("Test-I1");
    }
    public void Display1(){
        Console.WriteLine("Test-I2");
    }
}
class Test2{
    static void Main(){
        Test t1=new Test();
        t1.Display();
        t1.Display1();
    }
}