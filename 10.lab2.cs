using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Queue queue = new Queue();
        string input;

        while (true)
        {
            Console.WriteLine("\n1. Add customer");
            Console.WriteLine("2. Serve customer");
            Console.WriteLine("3. Exit");
            Console.Write("Choice: ");
            input = Console.ReadLine()!;

            if (input == "1")
            {
                Console.Write("Enter customer name: ");
                string name = Console.ReadLine()!;
                queue.Enqueue(name);
                Console.WriteLine($"{name} added to queue.");
            }
            else if (input == "2")
            {
                if (queue.Count > 0)
                    Console.WriteLine($"Serving: {queue.Dequeue()}");
                else
                    Console.WriteLine("Queue is empty!");
            }
            else if (input == "3")
                break;
        }
    }
}
