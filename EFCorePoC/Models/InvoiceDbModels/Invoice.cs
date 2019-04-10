using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Models.InvoiceDbModels
{
    public class Invoice
    {
        [Key]
        public int Id { get; set; }
        public int NumberOfItems { get; set; }
        public string TestItem { get; set; }
    }
}
