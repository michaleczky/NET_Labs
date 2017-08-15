using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Covariance
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice1 = new Invoice("First invoice", 1);
            Invoice invoice2 = new Invoice("Second invoice", 2);

            // the following line caused compile error before C# 4.0
            BusinessDocument[] docs = { invoice1, invoice2 };
        }
    }

    class BusinessDocument
    {        
        string Title { get; set; }

        public BusinessDocument(string title)
        {
            Title = title;
        }
    }

    class Invoice : BusinessDocument
    {
        int InvoiceNo { get; set; }

        public Invoice(string title, int invoiceNo) : base(title)
        {
            InvoiceNo = invoiceNo;
        }
    }

}
