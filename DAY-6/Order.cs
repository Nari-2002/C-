using System;
class Order{
    string item;
    double price;
    string specialization;
    Order(string i,double p=0.0,string s=null)
    {
        item=i;
        price=p;
        specialization=s;
        Console.WriteLine("=====Order======");
        Console.WriteLine("item: "+item);
        Console.WriteLine("price: "+price);
        Console.WriteLine("specialization: "+specialization);
    }
    static void Main(){
        Console.Write("item: ");
        string itm=Console.ReadLine();
        Console.Write("price: ");
        string prc=(Console.ReadLine());
        double p=string.IsNullOrEmpty(prc)?0.0:double.Parse(prc);
        Console.Write("specialization: ");
        string sp=Console.ReadLine();
        string pc=string.IsNullOrEmpty(prc)?null:(prc);
        Order o=new Order(itm,p,pc);
        
    }
}