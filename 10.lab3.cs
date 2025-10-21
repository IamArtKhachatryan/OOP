using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Stack commands = new Stack();
        string input;

        Console.WriteLine("Type commands. Type 'undo' to undo last, 'exit' to quit.");

        while (true)
        {
            Console.Write("> ");
            input = Console.ReadLine()!;

            if (input == "exit")
                break;
            else if (input == "undo")
            {
                if (commands.Count > 0)
                    Console.WriteLine($"Undo: {commands.Pop()}");
                else
                    Console.WriteLine("Nothing to undo.");
            }
            else
            {
                commands.Push(input);
                Console.WriteLine($"Command saved: {input}");
            }
        }
    }
}
