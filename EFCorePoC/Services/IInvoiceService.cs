using EFCorePoC.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Services
{
    public interface IInvoiceService
    {
        void PostInvoiceDTO(InvoiceDTO dto, int customerId, int productId);
        void DeleteInvoice(int invId);
        IEnumerable<SelectListItem> ReturnAllCustomers();
        IEnumerable<SelectListItem> ReturnAllProducts();
        //InvoiceDTO calculateTotalGross(InvoiceDTO dto);
        
    }
}
