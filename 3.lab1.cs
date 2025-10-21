using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0)
            Console.WriteLine("Positive");
        else if (number == 0)
            Console.WriteLine("Zero");
        else
            Console.WriteLine("Negative");
    }
}
