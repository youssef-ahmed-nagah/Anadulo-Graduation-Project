using Anadolu.Models;
using Anadolu.Repository.Base;

namespace Anadolu.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private readonly Context Context;
        public CategoryRepository(Context _Context) : base(_Context)
        {
            Context = _Context;
        }
    }
}
