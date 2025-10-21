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
            Console.Write("Մուտքագրիր առաջին թիվը։");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Մուտքագրիր երկրորդ թիվը։");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Արդյունք։ {num1 + num2}");
        }
    }
}
