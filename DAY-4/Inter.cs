using System;

class InterviewProcess
{
    static void Main()
    {
        Console.Write("Did you clear the written test? (yes/no): ");
        string wt = Console.ReadLine().ToLower();

        if (wt == "yes")
        {
            Console.WriteLine("You are eligible for the group discussion round");
            Console.Write("Did you pass the group discussion round? (yes/no): ");
            string dt = Console.ReadLine().ToLower();

            if (dt == "yes")
            {
                Console.WriteLine("You are eligible for the technical round");
                Console.Write("Did you pass the technical round? (yes/no): ");
                string t = Console.ReadLine().ToLower();

                if (t == "yes")
                {
                    Console.WriteLine("Congrats! You are eligible for the HR round");
                }
                else
                {
                    Console.WriteLine("Sorry, You can go home");
                }
            }
            else
            {
                Console.WriteLine("Sorry, You can go home");
            }
        }
        else
        {
            Console.WriteLine("Sorry, You can go home");
        }
    }
}
