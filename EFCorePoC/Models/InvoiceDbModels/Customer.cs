using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Models.InvoiceDbModels
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }


    }
}
