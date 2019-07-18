using EFCorePoC.Models.InvoiceDbModels;
using EFCorePoC.Repository;
using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCorePoC.GraphQL.Types
{
    public class InvoiceType: ObjectGraphType<Invoice>
    {
        public InvoiceType(ICustomerRepository customerRepository, IProductRepository productRepository)
        {
            Field(t => t.Id);
            Field(t => t.InvoiceNumber);
            Field(t => t.NumberOfItems).Description("This is the metaData that can be added to show more info in the schem docs");
            Field(t => t.InvoiceDate);
            Field(t => t.CustomerReference);
            Field<ListGraphType<CustomerType>>(
                "customers",
                resolve: context => customerRepository.ReturnCustomerById(context.Source.customerId)
                );
            Field<ListGraphType<ProductType>>(
                "products",
                resolve: context => productRepository.ReturnProductForInvoice(context.Source.productId)
                );
            //Field(t => t.Product);            
        }
    }
}
