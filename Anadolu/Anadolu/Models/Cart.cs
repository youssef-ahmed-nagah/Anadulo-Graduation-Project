using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class Cart
    {
        [Key]
        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public virtual User User { get; set; }
        public virtual List<ProductCart>? ProductCart { get; set;}

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
