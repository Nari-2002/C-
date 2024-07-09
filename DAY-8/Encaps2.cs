using System;
class Sample{
    private string name;
    public string Name{
        get {return name;}
        set {name=value;}
    }
}
class Test{
    static void Main(){
    Sample s=new Sample();
    s.Name="Nari";
    Console.WriteLine(s.Name);
}
}