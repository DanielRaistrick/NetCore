using EFCorePoC.Models.InvoiceDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Repository
{
    public interface ICustomerRepository
    {
        void CreateCustomer(Customer cust);

        void DeleteCustomer(int id);

        //note - delete this call when we have Chris/Nigel's end point
        List<Customer> ReturnAllCustomers();
    }
}
