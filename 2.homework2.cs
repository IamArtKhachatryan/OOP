using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the radius: ");
        double r = double.Parse(Console.ReadLine());

        double area = Math.PI * r * r;

        Console.WriteLine($"Area = {area}");
    }
}


