using System;
using System.Collections.Generic;

abstract class Shape
{
    public abstract double Area();
}

class Circle : Shape
{
    public double Radius { get; }

    public Circle(double radius)
    {
        Radius = radius;
    }

    public override double Area() => Math.PI * Radius * Radius;
}

class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(double width, double height)
    {
        Width = width;
        Height = height;
    }

    public override double Area() => Width * Height;
}

class Triangle : Shape
{
    public double BaseLength { get; }
    public double Height { get; }

    public Triangle(double baseLength, double height)
    {
        BaseLength = baseLength;
        Height = height;
    }

    public override double Area() => 0.5 * BaseLength * Height;
}

class Program
{
    static void Main()
    {
        var shapes = new List<Shape>
        {
            new Circle(3),
            new Rectangle(4, 5),
            new Triangle(6, 4)
        };

        double totalArea = 0;
        foreach (var shape in shapes)
        {
            Console.WriteLine($"{shape.GetType().Name} area = {shape.Area():F2}");
            totalArea += shape.Area();
        }

        Console.WriteLine($"Total area = {totalArea:F2}");
    }
}
