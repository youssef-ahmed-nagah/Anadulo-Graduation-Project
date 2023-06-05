using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class DiscountRepository : Repository<Discount>, IDiscountRepository
    {
        private readonly Context Context;
        public DiscountRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    
    }
}
