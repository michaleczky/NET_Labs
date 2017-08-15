using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionalException
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = 100;
            var divisor = 0;

            try
            {
                var result = Divide(num, divisor);
            }
            catch (DivideByZeroException)
            {
                if (num == 100)
                {
                    Console.WriteLine("Divide by 0!");
                }
                else throw;
            }


            try
            {               
                var result = Divide(num, divisor);
            }
            catch (DivideByZeroException) when (num == 100)
            {
                Console.WriteLine("Divide by 0!");
            }

            Console.ReadKey();
        }

        static float Divide(int num, int divisor)
        {
            return num / divisor;
        }

    }
}
