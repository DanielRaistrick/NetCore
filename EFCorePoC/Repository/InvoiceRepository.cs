using EFCorePoC.Models;
using EFCorePoC.Models.InvoiceDbModels;
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

        public void DeleteInvoice(int x)
        {
            var inv = _context.Invoices.Where(i => i.Id == x).FirstOrDefault();
            _context.Invoices.Remove(inv);
            _context.SaveChanges();
        }
    }
}
