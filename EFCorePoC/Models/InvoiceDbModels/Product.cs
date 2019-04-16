﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Models.InvoiceDbModels
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public double QuantityInStock { get; set; }
        public string Location { get; set; }
        public string ProductGroup { get; set; }
        public int TaxCode { get; set; }
        public string ProductCode { get; set; }
    }
}
