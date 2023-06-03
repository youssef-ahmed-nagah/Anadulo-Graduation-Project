using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class UserRepository : Repository<User>, IUserRepository
    {
        private readonly Context Context;
        public UserRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}