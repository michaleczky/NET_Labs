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

            // this is assignment compatibility (covariance)
            BusinessDocument[] docsarr = { invoice1, invoice2 };

            // example for covariance in generics
            IEnumerable<Invoice> invoices = new List<Invoice>() { invoice1, invoice2 };
            IEnumerable<BusinessDocument> docs = invoices;

            // contravariance example
            invoices.ToList().Sort(new BusinessDocComparer());

        }
    }

    class BusinessDocument
    {
        public string Title { get; set; }

        public BusinessDocument(string title)
        {
            Title = title;
        }

    }

    class Invoice : BusinessDocument
    {
        public int InvoiceNo { get; set; }

        public Invoice(string title, int invoiceNo) : base(title)
        {
            InvoiceNo = invoiceNo;
        }
    }

    class BusinessDocComparer : IComparer<BusinessDocument>
    {
        public int Compare(BusinessDocument x, BusinessDocument y)
        {
            return x.Title.CompareTo(y.Title);
        }
    }

}
