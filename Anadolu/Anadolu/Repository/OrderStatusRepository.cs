using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class OrderStatusRepository : Repository<OrderStatus>, IOrderStatusRepository
    {
        private readonly Context Context;
        public OrderStatusRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
