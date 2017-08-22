using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class InvoiceFactory
    {

        public IInvoice CreateInvoice(InvoiceType type, int id)
        {            
            switch (type)
            {
                case InvoiceType.NonTaxable:
                    return new Invoice() { InvoiceNo = id };
                case InvoiceType.Services:
                    return new ServicesInvoice() { InvoiceNo = id };
                case InvoiceType.Goods:
                    return new GoodsInvoice() { InvoiceNo = id };
            }
            return null;
        }

    }
}
