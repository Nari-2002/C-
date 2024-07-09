using System;
class SwitchObj{
    static void Main(){
    
        object obj="hello";
        obj=5;
        switch(obj){
            case int i:Console.WriteLine("int "+i);break;
            case string i:Console.WriteLine("string "+i);break;
        
        } 
    }
}