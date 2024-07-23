using Application.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    internal interface IProductService
    {
        public IEnumerable<Product> GetAllProducts();
        Product GetProductById(int ProductId);
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        bool DeleteProduct(int ProductId);
    }
}
