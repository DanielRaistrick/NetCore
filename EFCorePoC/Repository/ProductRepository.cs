using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFCorePoC.Models;
using EFCorePoC.Models.InvoiceDbModels;

namespace EFCorePoC.Repository
{
    public class ProductRepository : IProductRepository
    {
        private InvoiceDbContext _context;

        public ProductRepository(InvoiceDbContext context)
        {
            _context = context;
        }

        public void CreateProduct(Product product)
        {            
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {
            var product = _context.Products.Where(i => i.Id == id).FirstOrDefault();
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Product> ReturnAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product ReturnProductById(int id)
        {
            return _context.Products.Where(a => a.Id == id).SingleOrDefault();
        }
    }
}
