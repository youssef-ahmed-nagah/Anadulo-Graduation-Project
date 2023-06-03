using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class SubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ImagePath { get; set; }

        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set;}

        public virtual List<Product>? Products { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
