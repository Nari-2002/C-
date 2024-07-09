using System;
class CloneEx{
	static void Main(){
		string s1="nari";
		string s3="kumar";
		string s2=(string)s1.Clone();
		Console.WriteLine(s1);
		Console.WriteLine(s2);
		Console.WriteLine(string.Compare(s1,s3));								Console.WriteLine(string.CompareOrdinal(s1,s3));
		Console.WriteLine(s1.CompareTo(s3));
		string[] s={"nari","kamepalli"};
		Console.WriteLine(string.Join("-",s));
		
	}
}