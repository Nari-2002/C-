using System;
class Prime{
static void Main(){
bool flag=true;
int n=int.Parse(Console.ReadLine());
for(int i=2;i<=Math.Sqrt(n);i++){
if(n%i==0){
	flag=false;
	break;
}
if(flag){
Console.WriteLine(i);
}

}
}
}