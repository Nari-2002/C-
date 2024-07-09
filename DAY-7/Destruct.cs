using System;
class Test{
    int a=20;
    
    Test(){
        
        Console.WriteLine("a");
        public int b=10;
    }
    ~Test(){
        Console.WriteLine("I am a Destructor"+a);
    }
    static void Main(){
       Test t= new Test();
       Test t1=new Test();
    
    }
}