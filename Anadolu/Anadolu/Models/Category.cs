using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }
        
        public virtual List<SubCategory>? SubCategories { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
