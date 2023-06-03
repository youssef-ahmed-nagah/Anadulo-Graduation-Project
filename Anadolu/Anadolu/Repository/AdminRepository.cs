using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class AdminRepository : Repository<Admin>, IAdminRepository
    {
        private readonly Context Context;
        public AdminRepository(Context _Context):base(_Context)
        {
            Context = _Context;
        }
    }
}
