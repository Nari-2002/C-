using System;
interface College{
    void Clg();
}
interface CSE:College{
    void Cse();
}
interface ECE:College{
    void Ece();
}
interface EEE:College{
    void Eee();
}
class University:CSE,ECE,EEE{
    public void Clg(){
        Console.WriteLine("GEC");
    }
    public void Cse(){
        Console.WriteLine("CSE");
    }
    public void Ece(){
        Console.WriteLine("ECE");
    }
    public void Eee(){
        Console.WriteLine("EEE");
    }
    static void Main(){
        University u=new University();
        u.Clg();
        u.Cse();
        u.Ece();
        u.Eee();
    }
}
