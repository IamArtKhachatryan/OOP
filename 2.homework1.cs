using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the length: ");
        double length = double.Parse(Console.ReadLine());

        Console.Write("Enter the width: ");
        double width = double.Parse(Console.ReadLine());

        double area = length * width;
        double perimeter = 2 * (length + width);

        Console.WriteLine($"Area = {area}");
        Console.WriteLine($"Perimeter = {perimeter}");
    }
}
