using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.Models.InvoiceDbModels;
using System.ComponentModel.DataAnnotations;

namespace EFCorePoC.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }
        [Display(Name = "Quantity in Stock")]
        public double QuantityInStock { get; set; }

        public Product ConvertDTOToProduct (ProductDTO dto)
        {
            Product product = new Product();
            product.Id = dto.Id;
            product.Name = dto.Name;
            product.UnitPrice = dto.UnitPrice;
            product.QuantityInStock = dto.QuantityInStock;

            return product;
        }

    }
}
