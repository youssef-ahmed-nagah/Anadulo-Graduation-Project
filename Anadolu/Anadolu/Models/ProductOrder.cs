using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class ProductOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        public int OrderId { get; set; }
        [ForeignKey("OrderId")]
        public virtual Order Order { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
