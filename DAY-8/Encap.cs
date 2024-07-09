using System;
class Sample{
    private string name;
    public string GetName(){
        return name;
    }
    public void SetName(string newName){
        name=newName;
    }
}
class Test{
    static void Main(){
    Sample s=new Sample();
    s.SetName("Nari");
    Console.WriteLine(s.GetName());
}
}