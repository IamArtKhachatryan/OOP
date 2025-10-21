using System;
using System.Collections;

class DescendingComparer : IComparer
{
    public int Compare(object x, object y)
    {
        return ((IComparable)y).CompareTo(x); // Reverse order
    }
}

class Program
{
    static void Main()
    {
        ArrayList numbers = new ArrayList { 5, 2, 8, 1, 4 };

        Console.WriteLine("Before sorting:");
        foreach (int n in numbers)
            Console.Write(n + " ");

        numbers.Sort(new DescendingComparer());

        Console.WriteLine("\nAfter sorting (descending):");
        foreach (int n in numbers)
            Console.Write(n + " ");
    }
}
