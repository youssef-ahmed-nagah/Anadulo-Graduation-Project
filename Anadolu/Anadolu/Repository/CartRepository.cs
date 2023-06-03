using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class CartRepository : Repository<Cart>, ICartRepository
    {
        private readonly Context Context;
        public CartRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
