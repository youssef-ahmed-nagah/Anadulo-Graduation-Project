using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class ProductCart
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        
        public int ProductId { get; set; }
        [ForeignKey(("ProductId"))]
        public virtual Product Product { get; set; }
        public string CartId { get; set; }
        [ForeignKey("CartId")]
        public virtual Cart Cart { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
