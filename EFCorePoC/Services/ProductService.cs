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

        public List<ProductDTO> ReturnAllProducts()
        {
            //note replace this with a call to chris/nigel Serivce
            var productList = _repository.ReturnAllProducts();
            List<ProductDTO> allProductsDTOList = new List<ProductDTO>();
            foreach (var product in productList)
            {
                ProductDTO productDTO = new ProductDTO();
                productDTO.ConvertProductToDto(product);
                allProductsDTOList.Add(productDTO);
            }

            return allProductsDTOList;
        }
    }
}
