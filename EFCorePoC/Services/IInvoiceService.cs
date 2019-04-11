using EFCorePoC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Services
{
    public interface IInvoiceService
    {
        void PostInvoiceDTO(InvoiceDTO dto);
        void DeleteInvoice(int invId);
    }
}
