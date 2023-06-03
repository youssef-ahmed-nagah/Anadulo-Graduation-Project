using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class OrderRepository : Repository<Order>, IOrderRepository
    {
        private readonly Context Context;
        public OrderRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
