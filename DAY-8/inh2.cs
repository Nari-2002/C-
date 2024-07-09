using System;
interface I1{
    void Show();
}
interface I2:I1{
    void Show1();
}
class c1:I2{
    public void Show(){
        Console.WriteLine("hi");
    }
    public void Show1(){
        Console.WriteLine("hi1");
    }
    
}
class test{
    static void Main(){
        c1 c=new c1();
        c.Show();
    }
}