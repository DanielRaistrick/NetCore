using EFCorePoC.Models;
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

        public string getInfo()
        {
            var record = _context.Invoices.FirstOrDefault();
            return record.TestItem;
        }
    }
}
