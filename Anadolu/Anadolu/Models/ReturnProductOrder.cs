using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class ReturnProductOrder
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public int ProductId { get; set; }
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; }
        
        public int ReturnOrderId { get; set; }
        [ForeignKey("ReturnOrderId")]
        public virtual ReturnOrder ReturnOrder { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
