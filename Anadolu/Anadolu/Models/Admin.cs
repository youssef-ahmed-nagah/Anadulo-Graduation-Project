using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Anadolu.Models
{
    public class Admin
    {
        [Key]
        public string ApplicationUserId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string? ImagePath { get; set; }

        public DateTime BirthDate { get; set; }

        [ForeignKey("ApplicationUserId")]
        public virtual ApplicationUser ApplicationUser { get; set; }

        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
