using EFCorePoC.DTOs;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.ViewModels
{
    public class AddNewInvoiceViewModel
    {
        public InvoiceDTO invoiceDTO { get; set; }
        public IEnumerable<SelectListItem> customerList { get; set; }
        public IEnumerable<SelectListItem> productList { get; set; }
        public int customerId { get; set; }
        public int productId { get; set; }
    }
}
