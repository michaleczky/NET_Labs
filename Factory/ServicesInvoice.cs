using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ServicesInvoice : Invoice
    {
        public override double TaxRate()
        {
            return 0.2;
        }
    }
}
