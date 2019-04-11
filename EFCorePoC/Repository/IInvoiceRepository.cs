using EFCorePoC.Models.InvoiceDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Repository
{
    public interface IInvoiceRepository
    {
        void PostInvoice(Invoice inv);
        void DeleteInvoice(int id);
    }
}
