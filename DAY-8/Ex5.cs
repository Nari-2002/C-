using System;
interface Post{
    void SendLtr();
}
class Letter:Post{
    public string address{get; set;}
    public int pincode{get; set;}
    public Letter(string a,int p){
        address = a;
        pincode = p;
    }
    public void SendLtr(){
        Console.WriteLine("Sending letter to " + address);
    }
    static void Main(){
        Letter l1 = new Letter("123 Main Bommanampadu", 523201);
        Console.WriteLine("Address: " + l1.address);
        Console.WriteLine("Pincode: " + l1.pincode);
        l1.SendLtr();
    }
}
