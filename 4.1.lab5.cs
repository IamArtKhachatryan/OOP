using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 3, 7, 1, 9, 5 };
        var (min, max) = GetMinMax(numbers);
        Console.WriteLine($"Min = {min}, Max = {max}");
    }

    static (int min, int max) GetMinMax(int[] array)
    {
        int min = array[0];
        int max = array[0];

        foreach (int num in array)
        {
            if (num < min) min = num;
            if (num > max) max = num;
        }

        return (min, max);
    }
}
