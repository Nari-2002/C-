using System;
class SwitchWhen{
static void Main(){

int age=18;
switch(age){
case int a when a<18 :Console.WriteLine("adult");break;
case int a when a<18 && a>30 :Console.WriteLine("middle aged");break;

} 
}
}