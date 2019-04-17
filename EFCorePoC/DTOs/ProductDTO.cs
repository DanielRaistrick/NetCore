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

        //location
        public string Location { get; set; }
        //product Group
        public string ProductGroup { get; set; }
        //Tax code
        public int TaxCode { get; set; }
        //Product Code
        [Required(ErrorMessage = "This is an error message")]
        public string ProductCode { get; set; }
        //description
        //Weight
        //Cost Price
        //Unit of Sale
        //Free stock
        //Nominal Code
        //Web link
        //image
        //Discount structure

        public Product ConvertDTOToProduct (ProductDTO dto)
        {
            Product product = new Product();
            product.Id = dto.Id;
            product.Name = dto.Name;
            product.UnitPrice = dto.UnitPrice;
            product.QuantityInStock = dto.QuantityInStock;
            product.Location = dto.Location;
            product.TaxCode = dto.TaxCode;
            product.ProductCode = dto.ProductCode;


            return product;
        }

        public void ConvertProductToDTO(Product product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.Location = product.Location;
            this.ProductCode = product.ProductCode;
            this.ProductGroup = product.ProductGroup;
            this.QuantityInStock = product.QuantityInStock;
            this.TaxCode = product.TaxCode;
            this.UnitPrice = product.UnitPrice;
        }
    }
}
