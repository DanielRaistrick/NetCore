using EFCorePoC.Models.InvoiceDbModels;
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
        [Display(Name = "Product Code")]
        public string ProductCode { get; set; }

        public Invoice ConvertDTOToInvoice(InvoiceDTO dto, CustomerDTO custDTO)
        {
            Invoice invoice = new Invoice();
            invoice.Customer = new Customer();
            invoice.Id = 0;
            invoice.NumberOfItems = dto.NumberOfItems;
            invoice.Customer.Id = custDTO.Id;
            invoice.Customer.ContactFirstName = custDTO.ContactFirstName;
            invoice.Customer.ContactLastName = custDTO.ContactLastName;
            invoice.Customer.CustomerName = custDTO.CustomerName;
            invoice.CustomerReference = dto.CustomerReference;
            invoice.InvoiceNumber = dto.InvoiceNumber;
            invoice.InvoiceDate = dto.InvoiceDate;
            invoice.ProductCode = dto.ProductCode;
            
            return invoice;
        }
    }
}
