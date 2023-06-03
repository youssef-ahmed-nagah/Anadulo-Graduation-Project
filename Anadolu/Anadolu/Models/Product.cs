using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int? Quantity { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }

        [DefaultValue(0)]
        public float Offer { get; set; }

        public int SubCategoryId { get; set; }
        [ForeignKey("SubCategoryId")]
        public virtual SubCategory SubCategory { get; set; }

        public virtual List<ProductOrder>? ProductOrders { get; set; }
        public virtual List<ReturnProductOrder>? ReturnProductOrders { get; set; }
        public virtual List<ProductCart>? ProductCarts { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }

    }
}
