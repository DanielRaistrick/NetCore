using EFCorePoC.DTOs;
using EFCorePoC.Models.InvoiceDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Services
{
    public interface ICustomerService
    {
        void CreateCustomerDTO(CustomerDTO dto);
        void DeleteCustomer(int id);
        List<CustomerDTO> ReturnAllCustomers();
        //Customer ReturnCustomerById(int id);

        CustomerDTO ReturnCustomerByIdOld(int id);
    }
}
