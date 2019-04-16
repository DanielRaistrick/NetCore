using EFCorePoC.Models.InvoiceDbModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }
        [Display(Name = "Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Contact First Name")]
        public string ContactFirstName { get; set; }
        [Display(Name = "Contact last Name")]
        public string ContactLastName { get; set; }

        //Acc Ref
        //balance
        //Inactive
        //street1
        //street2
        //town
        //country
        //PostCode
        //Country
        //VAT number
        //Trade Contact
        //Telephone
        //Telephone2
        //Website
        //Social Media feeds
        //email addresses
        //credt control
        //defaults
        //communications
        //activity

        public Customer ConvertDTOToCustomer(CustomerDTO dto)
        {
            Customer customer = new Customer();
            customer.Id = dto.Id;
            customer.CustomerName = dto.CustomerName;
            customer.ContactFirstName = dto.ContactFirstName;
            customer.ContactLastName = dto.ContactLastName;

            return customer;
        }
    }   
}
