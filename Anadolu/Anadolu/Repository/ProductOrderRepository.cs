using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class ProductOrderRepository : Repository<ProductOrder>, IProductOrderRepository
    {
        private readonly Context Context;
        public ProductOrderRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
