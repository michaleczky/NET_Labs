using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskAsAsync
{
    class Program
    {
        static void Main(string[] args)
        {
            var task = CounterAsync(5);
            task.Wait();
            Console.WriteLine("Here we are...");

            Console.ReadKey();
        }

        static async Task<int> CounterAsync(int max)
        {
            int counter = 0;
            for (int i = 0; i < max; i++)
            {
                Console.WriteLine($"Task counter is {counter}");
                counter++;
                await WaitMe();
            }
            return counter;
        }

        static async Task WaitMe()
        {
            await Task.Delay(1000);
        }

    }

}
