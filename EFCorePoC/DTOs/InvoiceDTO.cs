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
        [Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Display(Name = "Contact First Name")]
        public string ContactFirstName { get; set; }
        [Display(Name = "Contact Last Name")]
        public string ContactLastName { get; set; }
        [Display(Name = "Invoice Date")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        public DateTime InvoiceDate { get; set; }
        [Display(Name = "Invoice Number")]
        public int InvoiceNumber { get; set; }

        public Invoice ConvertDTOToInvoice(InvoiceDTO dto)
        {
            Invoice invoice = new Invoice();
            invoice.Id = dto.Id;
            invoice.NumberOfItems = dto.NumberOfItems;
            invoice.CompanyName = dto.CompanyName;
            invoice.ContactFirstName = dto.ContactFirstName;
            invoice.ContactLastName = dto.ContactLastName;
            invoice.CustomerReference = dto.CustomerReference;
            invoice.InvoiceNumber = dto.InvoiceNumber;
            invoice.InvoiceDate = dto.InvoiceDate;
            
            //For Dan R to finish

            return invoice;
        }
    }
}
