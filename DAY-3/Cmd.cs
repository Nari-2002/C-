using System;
class Nari{
static void Main(string[] args){
foreach(string ele in args){
Console.WriteLine(int.Parse(ele));

}
string[] s=Environment.GetCommandLineArgs();
foreach(string ele in s){
Console.WriteLine(ele);
}
}
}