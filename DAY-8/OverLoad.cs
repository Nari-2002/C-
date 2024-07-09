using System;
class Test{
    string SayHi(string name){
        return name;
    }
    string SayHi(string n1,string n2){
        return n1+" "+n2;
    }
    static void Main(){
        Test T=new Test();
        Console.WriteLine(T.SayHi("nari"));
        Console.WriteLine(T.SayHi("nari","narendra"));
    }
}