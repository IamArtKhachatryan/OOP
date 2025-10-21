using System;

namespace OOP
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Number:");
            int num = int.Parse(Console.ReadLine());
            int res = 0;
            for (int i = 1; i <= num; i++)
                res += i;
            Console.WriteLine(res);
        }
    }
}
