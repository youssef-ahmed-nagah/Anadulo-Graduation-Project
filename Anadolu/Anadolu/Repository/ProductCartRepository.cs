using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class ProductCartRepository : Repository<ProductCart>, IProductCartRepository
    {
        private readonly Context Context;
        public ProductCartRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
