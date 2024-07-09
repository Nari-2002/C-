using System;
class Break{
 static void Main(){
  for(int i=0;i<9;i++){
	for(int j=0;j<9;j++){  	
	if(i==2 && j==2){
	  break;
	}
	Console.WriteLine(i+" "+j);
  }}
 }
}