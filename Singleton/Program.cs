using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = SingletonClass.getInstance();
            Console.WriteLine($"Instance count: {SingletonClass.counter}");
            var singleton2 = SingletonClass.getInstance();
            Console.WriteLine($"Instance count: {SingletonClass.counter}");
            var singleton3 = SingletonClass.getInstance();
            Console.WriteLine($"Instance count: {SingletonClass.counter}");

            Console.ReadKey();
        }

    }

}
