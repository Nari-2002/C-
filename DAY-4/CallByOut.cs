using System;

class CallByOut
{
    public void Show(out int val)
    {
        val = 10; 
        val += 5;
        Console.WriteLine("Value inside Show: " + val);
    }

    static void Main()
    {
        CallByOut c = new CallByOut();
        int val; 
        c.Show(out val);
        Console.WriteLine("Value after: " + val);
    }
}
