using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    // الادمن المفروض يضيف ديسكاوند علي البرودكت اللي
    // هيختاره من الليست اللي هتظهرله
    public class Discount
    {
        [Key]
        public int ProductId { get; set; }

        public DateTime StartDate { get; set; }

        public double Value { get; set; }

        public DateTime EndDate { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }
    }
}