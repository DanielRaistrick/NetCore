﻿using EFCorePoC.Models.InvoiceDbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.DTOs
{
    public class InvoiceDTO
    {
        public int Id { get; set; }
        [Display(Name = "Number of Items")]
        public int NumberOfItems { get; set; }
        [Display(Name = "Customer Reference")]
        public string CustomerReference { get; set; }
        [Display(Name = "Invoice Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime InvoiceDate { get; set; }
        [Display(Name = "Invoice Number")]
        public int InvoiceNumber { get; set; }
        [Display(Name = "Quantity")]
        public decimal Quantity { get; set; }
        [Display(Name = "Item Net")]
        public decimal ItemNet { get; set; }
        [Display(Name = "Total Net")]
        public decimal TotalNet { get; set; }
        [Display(Name = "Tax Rate")]
        public decimal TaxRate{ get; set; }
        [Display(Name = "Total Tax")]
        public decimal TotalTax { get; set; }
        [Display(Name = "Total Gross")]
        public decimal TotalGross { get; set; }

        public Invoice ConvertDTOToInvoice(InvoiceDTO dto, CustomerDTO custDTO, ProductDTO productDTO)
        {
            Invoice invoice = new Invoice();
            invoice.Customer = new Customer();
            invoice.Product = new Product();
            invoice.Id = 0;
            invoice.NumberOfItems = dto.NumberOfItems;
            invoice.Customer.Id = custDTO.Id;
            invoice.Customer.ContactFirstName = custDTO.ContactFirstName;
            invoice.Customer.ContactLastName = custDTO.ContactLastName;
            invoice.Customer.CustomerName = custDTO.CustomerName;
            invoice.CustomerReference = dto.CustomerReference;
            invoice.InvoiceNumber = dto.InvoiceNumber;
            invoice.Quantity = dto.Quantity;
            invoice.ItemNet = dto.ItemNet;
            invoice.TotalNet = dto.TotalNet;
            invoice.TotalTax = dto.TotalTax;
            invoice.TotalGross = dto.TotalGross;
            invoice.TaxRate = dto.TaxRate;
            invoice.InvoiceDate = dto.InvoiceDate;
            invoice.Product.Id = productDTO.Id;
            invoice.Product.Location = productDTO.Location;
            invoice.Product.Name = productDTO.Name;
            invoice.Product.ProductCode = productDTO.ProductCode;
            invoice.Product.ProductGroup = productDTO.ProductGroup;
            invoice.Product.QuantityInStock = productDTO.QuantityInStock;
            invoice.Product.TaxCode = productDTO.TaxCode;
            invoice.Product.UnitPrice = productDTO.UnitPrice;
            
            return invoice;
        }
    }
}
