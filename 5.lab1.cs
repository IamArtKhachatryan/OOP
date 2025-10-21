using System;

class Rectangle
{
    private double width;
    private double height;

    public double Width
    {
        get => width;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(Width), "Width must be > 0");
            width = value;
        }
    }

    public double Height
    {
        get => height;
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException(nameof(Height), "Height must be > 0");
            height = value;
        }
    }

    public double Area => Width * Height;

    public double Perimeter() => 2 * (Width + Height);

    public override string ToString()
        => $"Rectangle {Width}x{Height} (Area={Area}, Perimeter={Perimeter()})";
}

class Program
{
    static void Main()
    {
        try
        {
            var rect = new Rectangle { Width = 3, Height = 4 };
            Console.WriteLine(rect);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}
