using Anadolu.Models;

namespace Anadolu.Repository.Base
{
    public interface ICartRepository : IRepository<Cart>
    {
        List<ProductCart> GetCartItemsById(string id, Func<ProductCart, bool> predicate);
    }
}
