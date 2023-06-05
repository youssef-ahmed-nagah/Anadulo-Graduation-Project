using Anadolu.Models;

namespace Anadolu.Repository.Base
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetAllProductsinDiscount(Func<Product, bool> predicate);
        Product GetProductById(int id, Func<Product, bool> predicate);

        List<Product> GetAllProducts(Func<Product, bool> predicate);
    }
}
