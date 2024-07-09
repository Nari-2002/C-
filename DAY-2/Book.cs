using System;


public class Book{
		int BookID=191;
		double Price=1000;
		string Author="Narendra";
		string Title="Nari tales";
		int copiesAvailable=3;
		 void DisplayDetails(){
			Console.WriteLine("BookID:"+BookID);
			Console.WriteLine("Price:"+Price);
			Console.WriteLine("Author:"+Author);
			Console.WriteLine("Title:"+Title);
			Console.WriteLine("copiesAvailable:"+copiesAvailable);
		}
		void CalculateTotalValue(){
			Console.WriteLine("Total Cost:"+(Price*copiesAvailable));	
		}
		static void Main(){
			Book b=new Book();
			b.DisplayDetails();
			b.CalculateTotalValue();
		}


}

