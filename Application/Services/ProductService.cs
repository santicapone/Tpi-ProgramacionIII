using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProductService : IProductRepository
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository) 
        {
            _productRepository = productRepository;
        }

       public Product? GetProductById(int id)
        {
           
            return _productRepository.GetProductById(id);
        }
        public IEnumerable<Product> GetAllProducts() 
        {
            return _productRepository.GetAllProducts();
        }

        public void CreateProduct(Product product)
        {
            
;
        }

        public void UpdateProduct(Product product)
        {
        }

        public void DeleteProduct(int ProductId)
        {
            _productRepository.DeleteProduct(ProductId);
            
        }

                
    }
}
