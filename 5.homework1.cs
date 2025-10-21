using System;

struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public override bool Equals(object? obj)
        => obj is Point p && p.X == X && p.Y == Y;

    public override int GetHashCode() => HashCode.Combine(X, Y);

    public override string ToString() => $"({X}, {Y})";
}

class Program
{
    static void Main()
    {
        var p1 = new Point(3, 4);
        var p2 = new Point(3, 4);
        var p3 = new Point(5, 6);

        Console.WriteLine($"{p1} == {p2}? {p1.Equals(p2)}");
        Console.WriteLine($"{p1} == {p3}? {p1.Equals(p3)}");
    }
}
