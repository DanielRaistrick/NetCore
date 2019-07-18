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
    public class InvoiceAPIModel
    {
        public int Id { get; set; }        
        public int NumberOfItems { get; set; }      
        public DateTime InvoiceDate { get; set; }        
        public int InvoiceNumber { get; set; }   
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public string CustomerReference { get; set; }


        public Invoice ConvertModelToInvoice(InvoiceAPIModel model, CustomerDTO customerDTO, ProductDTO productDTO)
        {   
            Invoice invoice = new Invoice();            
            invoice.Customer = customerDTO.ConvertDTOToCustomer(customerDTO);
            invoice.Product = productDTO.ConvertDTOToProduct(productDTO);            
            invoice.Id = model.Id;            
            invoice.NumberOfItems = model.NumberOfItems;
            invoice.InvoiceNumber = model.InvoiceNumber;
            invoice.InvoiceDate = model.InvoiceDate;
            invoice.CustomerReference = model.CustomerReference;       

            return invoice;
        }
    }
}
