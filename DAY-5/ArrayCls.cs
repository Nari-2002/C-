using System;
class ArrayCls{
static void PrintArray(int[] a){
foreach(int x in a){
Console.Write(x+" ");
}
}
static void Main(){
int[] a={1,2,4,3};
Array.Sort(a);
PrintArray(a);
}
}