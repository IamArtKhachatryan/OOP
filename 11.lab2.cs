using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<string> names = new List<string>
        {
            "Anna", "David", "Aram", "Bella", "Artur", "Narek"
        };

        var filtered = names
            .Where(n => n.StartsWith("A", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Names starting with 'A':");
        foreach (var name in filtered)
            Console.WriteLine(name);
    }
}
