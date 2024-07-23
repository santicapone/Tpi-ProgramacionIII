using Domain.Entities;

namespace Domain.Interfaces
{
    public interface IProductRepository 
    {
        Product GetProductById(int ProductId);
        public IEnumerable<Product> GetAllProducts();
        void CreateProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int ProductId);

    }
}
