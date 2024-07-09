using System;
class Test{
    int a=20;
    static int b=90;
    static Test(){
        Console.WriteLine(b);
    }
    Test(int a){
        this.a=a;
        Console.WriteLine(a);
    }
    static void Main(){
        new Test(1);
    }
}