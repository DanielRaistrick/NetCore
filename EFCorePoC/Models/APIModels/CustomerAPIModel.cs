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
    public class CustomerAPIModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string ContactFirstName { get; set; }
        public string ContactLastName { get; set; }

        public Customer ConvertModelToCustomer(CustomerAPIModel model)
        {
            Customer customer = new Customer();
            customer.Id = model.Id;
            customer.CustomerName = model.CustomerName;
            customer.ContactFirstName = model.ContactFirstName;
            customer.ContactLastName = model.ContactLastName;

            return customer;
        }
    }
}
