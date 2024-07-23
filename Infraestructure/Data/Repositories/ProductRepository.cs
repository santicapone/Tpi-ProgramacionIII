using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Repositories
{
    public class ProductRepository : Repository , IProductRepository
    {
        public ProductRepository(ApplicationContext context) : base(context) { }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.ToList();
        }

        public Product GetProductById(int ProductId) 
        {
           return _context.Products.Find(ProductId);
        }

        public void CreateProduct(Product product) 
        {
            _context.Products.Add(product);
            SaveChanges();
        }

        public void UpdateProduct(Product product) 
        {
            _context.Products.Remove(product);
            SaveChanges();
        }

        public void DeleteProduct(int? id) 
        {
            _context.Products.Remove(_context.Products.Find(id));
            SaveChanges();
        }
    }
}
