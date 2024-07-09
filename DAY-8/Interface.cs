using System;
interface Drawable{
    void Rectangle();
}
class c1:Drawable{
    public void Rectangle(){
            Console.WriteLine("Rectangle1");
    }
}
class c2:Drawable{
    public void Rectangle(){
            Console.WriteLine("Rectangle2");
    }
}
class Test{
    
    static void Main(){
        c1 c=new c1();
        c2 d=new c2();
        c.Rectangle();
        d.Rectangle();
    }
}