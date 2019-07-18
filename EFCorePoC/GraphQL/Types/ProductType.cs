using EFCorePoC.Models.InvoiceDbModels;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.GraphQL.Types
{
    public class ProductType: ObjectGraphType<Product>
    {
        public ProductType()
        {
            Field(t => t.Id);
            Field(t => t.ProductCode);
            Field(t => t.Location);
            Field(t => t.Name);
            Field(t => t.QuantityInStock);
            Field(t => t.TaxCode);
        }
    }
}
