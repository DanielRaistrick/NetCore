using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        public string getInfo()
        {
            return "Hello World";
        }
    }
}
