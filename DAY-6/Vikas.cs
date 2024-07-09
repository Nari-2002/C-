using System;
class Teacher{
    double exp;
    string name;
    public Teacher(string name){
        exp=0.0;
        this.name=name;
        Console.WriteLine("Name: "+this.name);
        Console.WriteLine("Experience: "+exp);
    }
    public Teacher(string name,double exp){
        this.exp=exp;
        this.name=name;
        Console.WriteLine("Name: "+this.name);
        Console.WriteLine("Experience: "+this.exp);
    }
    static void Main(){
        Teacher t1=new Teacher("nari",10.2);
        Teacher t2=new Teacher("nari");
    }
}