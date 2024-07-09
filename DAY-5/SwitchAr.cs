using System;
class SwitchAr{
static void Main(){
	int day=3;
	string dayName = day switch
	
{
	0 => "mon";
	1 => "tues";
	2 => "wed";
	3 => "thrs";
	4 => "fri";
	5 => "sat";
	6 => "sun";
	_ =>"invalid";

}
Console.WriteLine("{0} is {1}",day,dayName);
}
}