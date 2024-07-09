using System;
abstract class Test{
    pubabstract void Show();
}
class Test2:Test{
    public override void Show(){
        Console.WriteLine("Nari")
    }
    static void Main(){
        Test1 t=new Test1();
        t.Show();
    }
}