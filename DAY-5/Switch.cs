using System;
class Switch{
static void Main(){
	int day=3;
	string dayName;
	
switch(day){

case 0:dayName="sun";break;
case 1:dayName="Mon";break;
case 2:dayName="Tue";break;
case 3:dayName="Wed";break;
case 4:dayName="Thrs";break;
case 5:dayName="Fri";break;
case 6:dayName="sat";break;
default:dayName="Invalid";break;

}
Console.WriteLine("{0} is {1}",day,dayName);
}
}