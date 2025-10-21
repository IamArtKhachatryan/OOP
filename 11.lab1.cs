using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<int> numbers = Enumerable.Range(1, 20).ToList();

        var evens = numbers.Where(n => n % 2 == 0);

        Console.WriteLine("Even numbers (1–20):");
        foreach (var n in evens)
            Console.Write(n + " ");
    }
}
