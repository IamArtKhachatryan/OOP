using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Even numbers from 1 to 20:");
        for (int i = 1; i <= 20; i++)
        {
            if (i % 2 == 0)
                Console.WriteLine(i);
        }
    }
}
