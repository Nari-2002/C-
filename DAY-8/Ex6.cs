using System;
class ExmSec{
    private int password;
    public void setPass(int p){
        password=p;
    }
    public int getPass(){
        return password;
    }
}
class Dept:ExmSec{
    public void Show(){
        Console.WriteLine("Pasword: "+getPass());

    }
}
class Student:Dept{
    public static void StudentName(){
        Console.WriteLine("Name: Narendra");
    }
    public static void StudentId(){
        Console.WriteLine("ID:"+101);
    }
}
class Test:Dept{
    static void Main(){
    Student s=new Student();
    s.setPass(109);
    s.Show();
    Student.StudentName();
    Student.StudentId();
}
}