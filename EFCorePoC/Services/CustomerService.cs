using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.DTOs;
using EFCorePoC.Models.InvoiceDbModels;
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

        public List<CustomerDTO> ReturnAllCustomers()
        {
            //note - replace this line with a call to Chris/Nigel's service
            var customerList = _repository.ReturnAllCustomers();
            List<CustomerDTO> allCustomerDTOList = new List<CustomerDTO>();
            foreach (var customer in customerList)
            {
                CustomerDTO customerDTO = new CustomerDTO();
                customerDTO.ConvertCustomerToDto(customer);
                allCustomerDTOList.Add(customerDTO);
            }

            return allCustomerDTOList;
        }

        public CustomerDTO ReturnCustomerByIdOld(int customerId)
        {
            //note - replace this with a call to the object cache ultimately
            CustomerDTO result = new CustomerDTO();
            result.ConvertCustomerToDto(_repository.ReturnCustomerByIdOld(customerId));
            return result;
        }

    }
}
