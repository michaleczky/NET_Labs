using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Examples
{
    class SingleResponsibility
    {

        class Invoice
        {
            public int InvoiceNo { get; set; }

            public void Save()
            {
                try
                {
                    // store the Invoice in the DB
                    // ...
                }
                catch (Exception ex)
                {
                    System.IO.File.WriteAllText(@"error.txt", ex.ToString());  // breaks the single responsibility principle
                }
            }

        }

    }


    // file logging responsibility removed to a separate class
    class SingleResponsibility_OK  
    {
        class Invoice
        {
            public int InvoiceNo { get; set; }
            private FileLogger fileLogger = new FileLogger();

            public void Save()
            {
                try
                {
                    // store the Invoice in the DB
                    // ...
                }
                catch (Exception ex)
                {
                    fileLogger.Error(ex.ToString());
                }
            }

        }

        class FileLogger
        {
            public void Error(string error)
            {
                System.IO.File.WriteAllText(@"error.txt", error);
            }
        }

    }
}
