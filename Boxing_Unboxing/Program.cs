using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing_Unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // boxing
            int num = 100;
            object boxed_num = (object)num;
            Console.WriteLine($"Number is {boxed_num}.");

            // unboxing
            int num_unboxed = (int)boxed_num;
            Console.WriteLine($"Number is still {num_unboxed}.");

            Console.ReadKey();

        }
    }
}
