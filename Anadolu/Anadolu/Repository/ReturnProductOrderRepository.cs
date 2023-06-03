using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class ReturnProductOrderRepository : Repository<ReturnProductOrder>, IReturnProductOrderRepository
    {
        private readonly Context Context;
        public ReturnProductOrderRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
