using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class User
    {
        [Key]
        public string ApplicationUserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string? ImagePath { get; set; }

        //ممكن نعمله جدول بالانواع الثابتة اللي هستخدمها 
        public string CardType { get; set; }
        
        [MinLength(12)]
        [MaxLength(12)]
        [NumbersOnly(ErrorMessage = "The property must contain only numeric values.")]
        public string CardNumber { get; set; }

        public int SecurityKey { get; set; }

        public DateTime ExpirationDate { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        //public string CartId { get; set; }
        //[ForeignKey("CartId")]
        //public virtual Cart Cart { get; set; }

        public virtual List<Order>? Orders { get; set; }
        public virtual List<ReturnOrder>? ReturnOrders { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
