using EFCorePoC.GraphQL.Types;
using EFCorePoC.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.GraphQL
{
    public class InvoiceQuery: ObjectGraphType
    {
        public InvoiceQuery(IInvoiceRepository invoiceRepository)
        {
            Field<ListGraphType<InvoiceType>>(
                "invoices",
                resolve: context => invoiceRepository.GetAll()
                );
        }
    }
}
