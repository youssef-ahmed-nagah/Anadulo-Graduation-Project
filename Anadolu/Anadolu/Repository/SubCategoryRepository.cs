using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class SubCategoryRepository : Repository<SubCategory>, ISubCategoryRepository
    {
        private readonly Context Context;
        public SubCategoryRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
