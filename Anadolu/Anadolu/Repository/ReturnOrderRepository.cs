using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class ReturnOrderRepository : Repository<ReturnOrder>, IReturnOrderRepository
    {
        private readonly Context Context;
        public ReturnOrderRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
