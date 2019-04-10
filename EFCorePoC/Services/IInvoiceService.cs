using EFCorePoC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Services
{
    public interface IInvoiceService
    {
        string getText();

        string LookAtInvoice(InvoiceDTO dto);
    }
}
