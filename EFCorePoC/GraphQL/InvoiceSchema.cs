using GraphQL;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.GraphQL
{
    public class InvoiceSchema: Schema
    {
        public InvoiceSchema(IDependencyResolver resolver): base(resolver)
        {
            Query = resolver.Resolve<InvoiceQuery>();
        }
    }
}
