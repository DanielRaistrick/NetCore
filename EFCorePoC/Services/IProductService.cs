using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.DTOs;

namespace EFCorePoC.Services
{
    public interface IProductService
    {
        void CreateProductDTO (ProductDTO dto);
        void DeleteProduct (int id);
    }
}
