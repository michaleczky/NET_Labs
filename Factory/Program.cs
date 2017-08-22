using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var invoiceFactory = new InvoiceFactory();
            var serviceInv = invoiceFactory.CreateInvoice(InvoiceType.Services, 1);
            var goodsInv = invoiceFactory.CreateInvoice(InvoiceType.Goods, 2);
            Console.WriteLine($"Taxrate for service invoice is {serviceInv.TaxRate()}.");
            Console.WriteLine($"Taxrate for goods invoice is {goodsInv.TaxRate()}.");

            Console.ReadKey();
        }
    }

}
