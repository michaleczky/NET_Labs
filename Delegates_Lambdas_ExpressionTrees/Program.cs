using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Lambdas_ExpressionTrees
{
    class Program
    {
        static void Main(string[] args)
        {
            // examples for lambdas
            Predicate<int> IsEven = x => x % 2 == 0;
            Func<int, int, int> Add = (a, b) => a + b;
            Action<string> Log = m => Console.WriteLine(m);

            Log($"IsEven(4) = {IsEven(4)}");
            Log($"Add(4,6) = {Add(4, 6)}");

            // LINQ lambda examples
            var number = new List<int>() { 10, 20, 30, 41, 50, 60, 70, 81, 91 };
            var oddNumbers = number.Where(x => x % 2 != 0).ToList();
            Console.Write("Odd numbers: ");
            oddNumbers.ForEach(x => Console.Write($"{x} "));
            Console.WriteLine();

            Console.ReadKey();

        }


    }

}
