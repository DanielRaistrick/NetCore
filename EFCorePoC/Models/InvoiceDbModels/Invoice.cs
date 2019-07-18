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
        public string CustomerReference { get; set; }
        public DateTime InvoiceDate { get; set; }
        public int InvoiceNumber { get; set; }
        public Customer Customer { get; set; }
        public Product Product { get; set; }

        public int customerId { get; set; }

        public int productId { get; set; }

        public decimal Quantity { get; set; }

        public decimal ItemNet { get; set; }
        public decimal TotalNet { get; set; }

        public decimal TotalTax { get; set; }

        public decimal TotalGross { get; set; }

        public decimal TaxRate { get; set; }

    }
}

