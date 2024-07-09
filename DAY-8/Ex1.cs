using System;
class Sample{
    public void Display(){
        Console.WriteLine("Sample");
    }
}
interface I1{
    void Show();
}

class test:Sample,I1{
  public void Show(){
    Console.WriteLine("Test");
  }
  static void Main(){
    test t1=new test();
    t1.Display();
    t1.Show();
  }

}