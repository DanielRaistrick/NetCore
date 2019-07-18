using EFCorePoC.Models.InvoiceDbModels;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.GraphQL.Types
{
    public class CustomerType: ObjectGraphType<Customer>
    {
        public CustomerType()
        {
            Field(t => t.Id);
            Field(t => t.ContactFirstName);
            Field(t => t.ContactLastName);
        }
    }
}
