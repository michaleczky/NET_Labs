using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculatorClient calc = new CalculatorClient(new Add());
            Console.WriteLine(calc.Calculate(7, 5));

            calc = new CalculatorClient(new Deduct());
            Console.WriteLine(calc.Calculate(7, 5));

            Console.ReadKey();
        }
    }
}
