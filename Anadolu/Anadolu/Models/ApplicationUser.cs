using Microsoft.AspNetCore.Identity;
using System.ComponentModel;

namespace Anadolu.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? ImagePath { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }
        
        [DefaultValue(false)]
        public bool IsDeleted { get; set; }
    }
}
        //public string Phone { get; set; }
