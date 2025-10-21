using System;

struct Rectangle
{
    public double Width { get; set; }
    public double Height { get; set; }

    public double GetArea()
    {
        return Width * Height;
    }
}

class Program
{
    static void Main()
    {
        Rectangle rect = new Rectangle { Width = 5, Height = 3 };
        Console.WriteLine($"Area = {rect.GetArea()}");
    }
}
