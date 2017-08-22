using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            // calculate the average tax rate of internal and external invoices using adapter pattern
            var inv1 = new Invoice() { InvoiceNo = 1 };
            var inv2 = new ExternalBillingDocument() { DocumentNumber = "E2", TaxRatePercent = "25" };
            IList<ITaxRate> invoices = new List<ITaxRate>() {
                inv1,
                new ExternalBillingDocumentTaxRateAdapter(inv2)
            };
            var avgTaxRate = invoices.Average(x => x.TaxRate());
            Console.WriteLine($"The average tax rate is {avgTaxRate}.");

            Console.ReadKey();
        }
    }
}
