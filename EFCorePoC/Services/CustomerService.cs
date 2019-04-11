using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.DTOs;
using EFCorePoC.Repository;

namespace EFCorePoC.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repository;

        public CustomerService(ICustomerRepository repository)
        {
            _repository = repository;
        }

        public void CreateCustomerDTO(CustomerDTO dto)
        {
            _repository.CreateCustomer(dto.ConvertDTOToCustomer(dto));
        }

        public void DeleteCustomer(int id)
        {
            _repository.DeleteCustomer(id);
        }
    }
}
