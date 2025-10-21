using System;

class Program
{
    static void Main()
    {
        string name = "";
        while (name.ToLower() != "exit")
        {
            Console.Write("Enter your name (or type 'exit' to quit): ");
            name = Console.ReadLine();
            if (name.ToLower() != "exit")
                Console.WriteLine($"Hello, {name}!");
        }
        Console.WriteLine("Program ended.");
    }
}
