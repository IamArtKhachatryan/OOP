using System;

class Counter
{
    private static int totalCreated;
    public int Id { get; }

    static Counter()
    {
        totalCreated = 0;
        Console.WriteLine("Static constructor called (class initialized)");
    }

    public Counter()
    {
        totalCreated++;
        Id = totalCreated;
    }

    public static int TotalCreated => totalCreated;
}

class Program
{
    static void Main()
    {
        var c1 = new Counter();
        var c2 = new Counter();
        var c3 = new Counter();

        Console.WriteLine($"Counter 1 ID: {c1.Id}");
        Console.WriteLine($"Counter 2 ID: {c2.Id}");
        Console.WriteLine($"Counter 3 ID: {c3.Id}");
        Console.WriteLine($"Total created: {Counter.TotalCreated}");
    }
}
