using System;
interface BusDepo{
    void BusDetails1();
}
abstract class BusDepo2{
    public abstract void BusDetails2();
}
class MainDepo:BusDepo2,BusDepo{
    public override void BusDetails2()
    {
        Console.WriteLine("Bus-2 in Depot 2");
    }
    public void BusDetails1(){
        Console.WriteLine("Bus-1 in Depot 1");
    }
    static void Main(){
        MainDepo m=new MainDepo();
        m.BusDetails1();
        m.BusDetails2();
    }
}