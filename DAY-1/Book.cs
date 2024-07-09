using System;


public class Book{
		int BookID=191;
		double Price=1000;
		string Author="Narendra";
		string Title="Nari tales";
		int copiesAvailable=3;
		static void DisplayDetails(){
			Console.WriteLine("BookID:"+BookID);
			Console.WriteLine("Price:"+Price);
			Console.WriteLine("Author:"+Author);
			Console.WriteLine("Title:"+Title);
			Console.WriteLine("copiesAvailable:"+copiesAvailable);
		}
		static void CalculateTotalValue(){
			Console.WriteLine("Total Cost:"+(Price*copiesAvailable));	
		}
		static void Main(){
			Book.DisplayDetails();
			Book.CalculateTotalValue();
		}


}

