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

        public DateTime DiscountStartDate { get; set; }

        public double DiscountValue { get; set; }

        public DateTime DiscountEndDate { get; set; }

        [ForeignKey("ProductId")]
        public virtual Product? Product { get; set; }
    }
}