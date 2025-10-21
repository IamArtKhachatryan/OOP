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
            Console.Write("Գրիր քո անունը։");
            string name = Console.ReadLine();
            Console.Write("Գրիր քո տարիքը։");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine($"Բարև,{name}, դու {age} տարեկան ես։");
        }
    }
}
