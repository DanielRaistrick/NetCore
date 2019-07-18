using EFCorePoC.Models;
using EFCorePoC.Models.InvoiceDbModels;
using Microsoft.EntityFrameworkCore;
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

        public void UpdateCustomer(Customer cust)
        {
            _context.Customers.Update(cust);
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

        public IQueryable<Customer> ReturnCustomer(int id)
        {           

            IQueryable<Customer> returnCust = _context.Customers.Where(c => c.Id == id);
            //if (returnCust != null)
            return returnCust;

            //return null;
        }
        //note - delete when we have an object cache
        public Customer ReturnCustomerByIdOld(int id)
        {
            return _context.Customers.Where(c => c.Id == id).FirstOrDefault();
        }

        public IEnumerable<Customer> ReturnCustomerById(int id)
        {
            return _context.Customers.Where(c => c.Id == id).ToList();
        }


    }
}
