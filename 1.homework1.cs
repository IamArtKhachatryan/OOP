using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ձեր անունը։");
            string name = Console.ReadLine();
            Console.Write("Ձեր ազգանունը։");
            string surname = Console.ReadLine();
            Console.Write("Քաղաքը։");
            string city = Console.ReadLine();
            Console.WriteLine($"Ես {name} {surname} եմ, ապրում եմ {city}-ում։");
        }
    }
}
