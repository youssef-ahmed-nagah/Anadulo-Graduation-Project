using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>,IApplicationUserRepository
    {
        private readonly Context Context;
        public ApplicationUserRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }

        public ApplicationUser GetByUserName(string userName)
        {
            ApplicationUser user = Context.ApplicationUsers
                .Where(a => a.UserName == userName).FirstOrDefault();

            return user;
        }
    }
}
