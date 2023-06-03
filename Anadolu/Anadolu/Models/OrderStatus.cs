using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class OrderStatus
    {
        public int Id { get; set; }
        public string Status { get; set; }
        
        //public int OrderId { get; set; }
        //[ForeignKey("OrderId")]
        //public virtual Order Order { get; set;}
        public virtual List<Order>? Orders { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
