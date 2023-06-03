using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class ReturnOrder
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public User User { get; set; }
        
        public virtual List<ReturnProductOrder>? ReturnProductOrders { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
