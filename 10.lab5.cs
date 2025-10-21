using System;
using System.Collections.Specialized;

class Program
{
    static void Main()
    {
        OrderedDictionary students = new OrderedDictionary();

        students["S001"] = "Anna";
        students["S002"] = "David";
        students["S003"] = "Bella";

        Console.WriteLine("All students:");
        foreach (string key in students.Keys)
            Console.WriteLine($"{key} - {students[key]}");

        // First entered student
        if (students.Count > 0)
        {
            string firstKey = (string)students.Cast<System.Collections.DictionaryEntry>().First().Key;
            Console.WriteLine($"\nFirst entered student: {students[firstKey]}");
        }
    }
}
