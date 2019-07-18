using EFCorePoC.Models.InvoiceDbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.Repository
{
    public interface IInvoiceRepository
    {
        void PostInvoice(Invoice inv);
        void DeleteInvoice(int id);
        void UpdateInvoice(Invoice invoice);

        List<Invoice> ReturnAllInvoices();

        IQueryable<Invoice> ReturnInvoice(int id);

        IEnumerable<Invoice> GetAll();

        IQueryable<Customer> GetCustomerForInvoice(int id);
    }
}
