using System;

class Program
{
    static void Main()
    {
        if (Divide(10, 2, out int result))
            Console.WriteLine($"Result: {result}");
        else
            Console.WriteLine("Division by zero is not allowed!");
    }

    static bool Divide(int a, int b, out int result)
    {
        if (b == 0)
        {
            result = 0;
            return false;
        }
        result = a / b;
        return true;
    }
}
