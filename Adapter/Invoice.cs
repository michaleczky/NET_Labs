using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Invoice: ITaxRate
    {
        public int InvoiceNo { get; set; }

        public double TaxRate()
        {
            return 0.18;
        }

    }
}
