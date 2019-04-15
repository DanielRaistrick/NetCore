using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.DTOs;
using EFCorePoC.Repository;

namespace EFCorePoC.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService (IProductRepository repository)
        {
            _repository = repository;
        }
        public void CreateProductDTO (ProductDTO dto)
        {
            _repository.CreateProduct(dto.ConvertDTOToProduct(dto));
        }

        public void DeleteProduct (int id)
        {
            _repository.DeleteProduct(id);
        }
    }
}
