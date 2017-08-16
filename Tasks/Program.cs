using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Tasks
{
    class Program
    {
        static void Main(string[] args)
        {       
            var task = new Task<int>(() => Counter(5));
            task.Start();
            task.Wait();

            Console.WriteLine("Here we are...");
            Console.ReadKey();
        }

        static int Counter(int max)
        {
            int counter = 0;            
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"Task counter is {counter}");
                counter++;
                Thread.Sleep(1000);                
            }
            return counter;
        }
    }
}
