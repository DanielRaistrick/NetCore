using EFCorePoC.DTOs;
using EFCorePoC.Models.InvoiceDbModels;
using EFCorePoC.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Models.APIModels
{
    public class ProductAPIModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public double QuantityInStock { get; set; }
        public string Location { get; set; }
        public string ProductGroup { get; set; }
        public int TaxCode { get; set; }
        public string ProductCode { get; set; }


        public Product ConvertModelToProduct(ProductAPIModel model)
        {
            Product product = new Product();
            //product.Customer = customerDTO.ConvertDTOToCustomer(customerDTO);
            //product.Product = productDTO.ConvertDTOToProduct(productDTO);
            product.Name = model.Name;
            product.Id = model.Id;
            product.UnitPrice= model.UnitPrice;
            product.QuantityInStock = model.QuantityInStock;
            product.Location = model.Location;
            product.ProductGroup = model.ProductGroup;
            product.TaxCode = model.TaxCode;
            product.ProductCode = model.ProductCode;

            return product;
        }
    }
}
