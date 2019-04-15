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

    }
}
