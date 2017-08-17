using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TaskAsAsync
{
    class Program_OriginalWay
    {        

        static void Main_Old(string[] args)
        {
            var task = CounterAsync(5);
            task.Wait();
            Console.WriteLine("Here we are...");

            Console.ReadKey();            

        }

        static Task<int> CounterAsync(int max)
        {
            return Task.Factory.StartNew<int>(() =>
            {
                int counter = 0;
                for (int i = 0; i < max; i++)
                {
                    Console.WriteLine($"Task counter is {counter}");
                    counter++;
                    var task = WaitMe();
                    task.Wait();
                }
                return counter;

            });
        }

        static Task WaitMe()
        {
            return Task.Factory.StartNew(() => Thread.Sleep(1000));            
        }

    }

}
