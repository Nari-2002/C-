using System;
class MulArr{
static void Main(){
int[,] a={{1,2,3},{1,2,3}};
foreach(int[] r in a){
foreach(int c in r){
Console.Write(c+" ");
}
Console.WriteLine();
}
}
}