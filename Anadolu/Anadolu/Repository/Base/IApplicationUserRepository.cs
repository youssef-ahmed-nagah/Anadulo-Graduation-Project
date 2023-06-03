using Anadolu.Models;

namespace Anadolu.Repository.Base
{
    public interface IApplicationUserRepository : IRepository<ApplicationUser>
    {
        ApplicationUser GetByUserName(string userName);
    }
}
