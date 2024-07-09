using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        string result = "";

        foreach (char c in input)
        {
            char incrementedChar = (char)(c + 1);
            if (char.IsLetter(incrementedChar))
            {
                if (char.IsUpper(incrementedChar))
                {
                    result += char.ToLower(incrementedChar);
                }
                else
                {
                    result += char.ToUpper(incrementedChar);
                }
            }
            else
            {
                result += incrementedChar;
            }
        }

        Console.WriteLine("Transformed string:");
        Console.WriteLine(result);
    }
}
