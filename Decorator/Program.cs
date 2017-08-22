using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var inv = new Invoice() { InvoiceNo = 1, Total = 100 };
            var discounted = new PartnerDiscount(inv);
            Console.WriteLine($"Discounted total is {discounted.Total}.");

            Console.ReadKey();
        }
    }
}
