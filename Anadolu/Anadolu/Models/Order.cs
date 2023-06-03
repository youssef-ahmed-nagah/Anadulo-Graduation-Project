
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Schema;

namespace Anadolu.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }

        public int OrderStatusId { get; set; }
        [ForeignKey("OrderStatusId")]
        public virtual OrderStatus OrderStatus { get; set; }


        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        public virtual List<ProductOrder>? ProductOrders { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
