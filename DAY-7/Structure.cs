using System;
struct Test{
    void Hi(){
        Console.WriteLine("Struct");

    }
};
class Test1{
    Test t;
    t.Hi();
}