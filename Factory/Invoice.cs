using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Invoice : IInvoice
    {
        public int InvoiceNo { get; set; }
        public virtual double TaxRate()
        {
            return 0.0;
        }

    }
}
