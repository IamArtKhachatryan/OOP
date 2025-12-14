using System;
using System.Collections.Generic;

namespace Lab4_FuncAction_MethodGroup
{
    class Program
    {
        static IEnumerable<T> Transform<T>(IEnumerable<T> src, Func<T, T> map)
        {
            foreach (var x in src)
                yield return map(x);
        }

        static void Main()
        {
            var words = new[] { "hello", "armenia", "csharp" };
            var upper = Transform(words, s => s.ToUpperInvariant());
            Console.WriteLine(string.Join(", ", upper));

            var nums = new[] { 1, 2, 3, 4, 5 };
            var squares = Transform(nums, x => x * x);
            Console.WriteLine(string.Join(", ", squares));

            var absVals = Transform(new[] { -3, -1, 0, 2 }, Math.Abs);
            Console.WriteLine(string.Join(", ", absVals));
        }
    }
}
