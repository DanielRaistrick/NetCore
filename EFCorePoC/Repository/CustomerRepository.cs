using EFCorePoC.Models;
using EFCorePoC.Models.InvoiceDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Repository
{
    public class CustomerRepository : ICustomerRepository
    {
        private InvoiceDbContext _context;

        public CustomerRepository(InvoiceDbContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Customer cust)
        {
            _context.Customers.Add(cust);
            _context.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var cust = _context.Customers.Where(i => i.Id == id).FirstOrDefault();
            _context.Customers.Remove(cust);
            _context.SaveChanges();
        }

        //Note - delete when we have Nigel/Chris's end point
        public List<Customer> ReturnAllCustomers()
        {
            return _context.Customers.ToList();
        }
    }
}
