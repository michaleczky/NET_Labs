using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples
{
    class OpenClose
    {

        // the following example are breaks the Open/Close principle. To introduce a new InvoiceType
        // the TaxRate method must be changed.

        enum InvoiceType { Services, Goods };

        class Invoice
        {
            public int InvoiceNo { get; set; }
            public InvoiceType type { get; set; }

            public double TaxRate()
            {
                if (type == InvoiceType.Services)
                {
                    return 0.2;
                }
                else
                {
                    return 0.15;
                }
            }

        }

    }

    class OpenClose_OK
    {

        // this structure is open for extension, but closed for modification by making difference by inheritance
        // of Invoice

        class Invoice
        {
            public int InvoiceNo { get; set; }
            public virtual double TaxRate()
            {
                return 0.0;
            }

        }

        class ServicesInvoice: Invoice
        {
            public override double TaxRate()
            {
                return 0.2;
            }
        }

        class GoodsInvoice : Invoice
        {
            public override double TaxRate()
            {
                return 0.15;
            }
        }

    }
}
