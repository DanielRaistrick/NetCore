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

        //void EditCustomer(Customer cust);
    }
}
