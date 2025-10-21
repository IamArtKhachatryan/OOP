using System;
using System.Collections.Generic;

interface IShape
{
    double Area();
}

class Circle : IShape
{
    public double Radius { get; }
    public Circle(double radius) => Radius = radius;

    public double Area() => Math.PI * Radius * Radius;
}

class Rectangle : IShape
{
    public double Width { get; }
    public double Height { get; }
    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public double Area() => Width * Height;
}

class Program
{
    static void Main()
    {
        var shapes = new List<IShape>
        {
            new Circle(3),
            new Rectangle(4, 5)
        };

        foreach (var s in shapes)
            Console.WriteLine($"{s.GetType().Name} area = {s.Area():F2}");
    }
}
