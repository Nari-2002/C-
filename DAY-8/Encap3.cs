using System;
class Sample{
    public string Name {get;set;}
}
class Test{
    static void Main(){
    Sample s=new Sample();
    s.Name="Nari";
    Console.WriteLine(s.Name);
}
}