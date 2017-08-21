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

        // Singleton pattern implementation using Lazy instantiation and private constructor
        class SingletonClass
        {
            private static readonly Lazy<SingletonClass> _instance = new Lazy<SingletonClass>(()=>new SingletonClass());
            public static int counter = 0;

            private SingletonClass()
            {
                // private contstructor avoids direct instantiation of the SingletonClass
                counter++;
            }

            public static SingletonClass getInstance()
            {
                return _instance.Value;
            }

        }

    }
}
