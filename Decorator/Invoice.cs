using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Invoice: IInvoice
    {
        public int InvoiceNo { get; set; }
        public double Total { get; set; }
    }
}
