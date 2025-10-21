using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable phoneBook = new Hashtable
        {
            { "Anna", "093111222" },
            { "David", "094333444" },
            { "Bella", "099555666" }
        };

        Console.Write("Enter name to search: ");
        string name = Console.ReadLine()!;

        if (phoneBook.ContainsKey(name))
            Console.WriteLine($"{name}'s number: {phoneBook[name]}");
        else
            Console.WriteLine("Name not found!");
    }
}
