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
