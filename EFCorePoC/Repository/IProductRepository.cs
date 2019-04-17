using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.Models.InvoiceDbModels;

namespace EFCorePoC.Repository
{
    public interface IProductRepository
    {
        void CreateProduct(Product product);

        void DeleteProduct(int id);

        //void EditProduct(Product product);

        //note - delete this call when we have Chris/Nigel's end point
        List<Product> ReturnAllProducts();

    }
}
