using EFCorePoC.Models;
using EFCorePoC.Models.InvoiceDbModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Repository
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private InvoiceDbContext _context;

        public InvoiceRepository(InvoiceDbContext context)
        {
            _context = context;
        }


        public void PostInvoice(Invoice inv)
        {
            _context.Invoices.Add(inv);
            _context.SaveChanges();
        }
        public void UpdateInvoice(Invoice invoice)
        {
            try
            {
                _context.Invoices.Update(invoice);
            }
            catch (Exception ex)
            {

                int y = 8;
            }
            
            _context.Products.Update(invoice.Product);
            _context.Customers.Update(invoice.Customer);
            _context.SaveChanges();
        }

        public void DeleteInvoice(int id)
        {
            var inv = _context.Invoices.Where(i => i.Id == id).FirstOrDefault();
            _context.Invoices.Remove(inv);
            _context.SaveChanges();
        }
        public List<Invoice> ReturnAllInvoices()
        {
            return _context.Invoices.ToList();
        }
        
        public IQueryable<Invoice> ReturnInvoice(int id)
        {

            IQueryable<Invoice> returnInv = _context.Invoices.Where(c => c.Id == id);
            //if (returnProd != null)
            
            return returnInv;

            //return null;
        }

        public IEnumerable<Invoice> GetAll()
        {
            return _context.Invoices;
        }

        public IQueryable<Customer> GetCustomerForInvoice(int id)
        {
            IQueryable<Customer> returnCust = _context.Customers.Where(c => c.Id == id);
            return returnCust;
        }
        

        //public Task<List<Invoice>> GetAll()
        //{
        //    return _context.Invoices.ToListAsync();
        //}
    }
}
