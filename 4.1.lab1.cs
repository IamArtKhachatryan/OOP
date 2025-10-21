using System;

class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        for (int i = 0; i < matrix.GetLength(0); i++) // iterate rows
        {
            int sum = 0;
            for (int j = 0; j < matrix.GetLength(1); j++) // iterate columns
            {
                sum += matrix[i, j];
            }
            Console.WriteLine($"Sum of row {i + 1}: {sum}");
        }
    }
}
