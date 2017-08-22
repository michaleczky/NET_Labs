using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class PartnerDiscount : IInvoice
    {
        public int InvoiceNo
        {
            get { return _invoice.InvoiceNo; }
        }

        public double Total
        {
            get { return _invoice.Total * (1 - _discount); }
        }

        private double _discount = 0.15;

        private IInvoice _invoice;

        public PartnerDiscount(IInvoice invoice)
        {
            _invoice = invoice;
        }
    }
}
