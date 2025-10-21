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
            Console.WriteLine($"Գումարը։ {num1 + num2}");
            Console.WriteLine($"Տարբերությունը։ {num1 - num2}");
            Console.WriteLine($"Արտադրյալը։ {num1 * num2}");
            if(num2 != 0)
                Console.WriteLine($"Քանորդը։ {num1 / num2}");
            else
                Console.WriteLine($"Հնարավոր չէ թիվը բաժանել 0-ի");

        }
    }
}
