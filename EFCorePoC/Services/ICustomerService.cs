using EFCorePoC.DTOs;
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
    }
}
