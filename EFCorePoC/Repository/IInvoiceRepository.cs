using EFCorePoC.Models.InvoiceDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Repository
{
    public interface IInvoiceRepository
    {
        string getInfo();

        Invoice AcceptInvoice(Invoice inv);
    }
}
