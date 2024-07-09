using System;

class PrimeNumbers
{
    static void Main()
    {
        Console.Write("Enter the end of the range: ");
        int range =int.Parse(Console.ReadLine());
        

       
            Console.WriteLine("Prime numbers up to {0}:", range);

            for (int num = 2; num <= range; num++)
            {
                bool Prime = true;

                for (int i = 2; i <= num; i++)
                {
                    if (num % i == 0)
                    {
                        Prime = false;
                        break;
                    }
		    if (Prime)
                    {
                    Console.Write(num + " ");
                    }
                }

                
            }
        }
        
    
}
