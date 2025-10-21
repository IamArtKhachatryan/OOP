using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number (1-4): ");
        int choice = int.Parse(Console.ReadLine());

        Console.Write("Enter the first number: ");
        double num1 = double.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double num2 = double.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.WriteLine($"Sum = {num1 + num2}");
                break;
            case 2:
                Console.WriteLine($"Difference = {num1 - num2}");
                break;
            case 3:
                Console.WriteLine($"Product = {num1 * num2}");
                break;
            case 4:
                if (num2 != 0)
                    Console.WriteLine($"Quotient = {num1 / num2}");
                else
                    Console.WriteLine("Cannot divide by zero!");
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}
