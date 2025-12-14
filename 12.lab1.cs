using System;
using System.Collections.Generic;

class BigObject
{
    public byte[] Data = new byte[100_000];
}

class Program
{
    static void Main()
    {
        const int n = 50_000;

        var list = new List<BigObject>(n);

        for (int i = 0; i < n; i++)
            list.Add(new BigObject());

        var sample1 = list[0];
        var sample2 = list[n / 2];
        var sample3 = list[n - 1];

        Console.WriteLine("Before GC.Collect():");
        Console.WriteLine($"sample1 gen = {GC.GetGeneration(sample1)}");
        Console.WriteLine($"sample2 gen = {GC.GetGeneration(sample2)}");
        Console.WriteLine($"sample3 gen = {GC.GetGeneration(sample3)}");
        Console.WriteLine($"Total memory = {GC.GetTotalMemory(false):N0} bytes");

        // Անջատենք reference-ները
        list = null;
        sample1 = null;
        sample2 = null;
        sample3 = null;

        Console.WriteLine("\nForcing GC...");
        GC.Collect();
        GC.WaitForPendingFinalizers();
        GC.Collect();

        Console.WriteLine("After GC.Collect():");
        Console.WriteLine($"Total memory = {GC.GetTotalMemory(true):N0} bytes");
        Console.WriteLine($"GC collections: Gen0={GC.CollectionCount(0)}, Gen1={GC.CollectionCount(1)}, Gen2={GC.CollectionCount(2)}");

        Console.WriteLine("\nDone.");
    }
}
