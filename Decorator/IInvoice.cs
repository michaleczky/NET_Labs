using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    interface IInvoice
    {
        int InvoiceNo { get; }
        double Total { get; }
    }
}
