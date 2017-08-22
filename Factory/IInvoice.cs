using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    interface IInvoice
    {
        int InvoiceNo { get; set; }
        double TaxRate();
    }
}
