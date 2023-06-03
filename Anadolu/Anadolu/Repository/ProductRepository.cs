using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly Context Context;
        public ProductRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
