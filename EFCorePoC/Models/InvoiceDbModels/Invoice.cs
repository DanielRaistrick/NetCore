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

        public string CompanyName { get; set; }

        public string ContactFirstName { get; set; }

        public string ContactLastName { get; set; }

        public DateTime InvoiceDate { get; set; }

        public int InvoiceNumber { get; set; }






    }
}
