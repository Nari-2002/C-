using System;

class Rank
{
    static void Main()
    {
        Console.Write("Enter your marks: ");
        int marks =int.Parse(Console.ReadLine());
        
            if (marks >= 90 && marks <= 100)
            {
                Console.WriteLine("Congratulations! You got 1st rank.");
            }
            else if (marks >= 75 && marks < 90)
            {
                Console.WriteLine("You got 2nd rank.");
            }
            else if (marks >= 50 && marks < 75)
            {
                Console.WriteLine("You got 3rd rank.");
            }
            else if (marks >= 35 && marks < 50)
            {
                Console.WriteLine("You just passed.");
            }
            else if (marks >= 10 && marks < 35)
            {
                Console.WriteLine("You failed.");
            }
            else
            {
                Console.WriteLine("Invalid credentials. Please enter valid marks.");
            }
        
    }
}
