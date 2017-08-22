using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class ExternalBillingDocumentTaxRateAdapter: ITaxRate
    {

        ExternalBillingDocument _document;

        public ExternalBillingDocumentTaxRateAdapter(ExternalBillingDocument document)
        {
            _document = document;
        }

        public double TaxRate()
        {
            return Double.Parse(_document.TaxRatePercent) / 100;
        }
    }
}
