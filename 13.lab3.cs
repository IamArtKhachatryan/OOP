using System;

namespace Lab3_Closures
{
    class Program
    {
        static Action MakeCounter(int start)
        {
            int value = start;
            return () =>
            {
                Console.WriteLine($"Counter value = {value}");
                value++;
            };
        }

        static void Main()
        {
            Action c1 = MakeCounter(0);
            Action c2 = MakeCounter(10);

            c1(); c1(); c1();
            c2(); c2();
            c1();
        }
    }
}
