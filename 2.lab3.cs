using System;

class Program
{
    static void Main()
    {
        Console.Write("Do you have an ID card? (true/false): ");
        bool hasID = bool.Parse(Console.ReadLine());

        Console.Write("Do you have a ticket? (true/false): ");
        bool hasTicket = bool.Parse(Console.ReadLine());

        if (hasID && hasTicket)
            Console.WriteLine("Access is allowed.");
        else
            Console.WriteLine("Access is denied.");
    }
}
