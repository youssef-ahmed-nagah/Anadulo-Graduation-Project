using System.ComponentModel.DataAnnotations;

namespace Anadolu.DTO
{
    public class RegisterDTO
    {
        [Required(ErrorMessage = "The FirstName Field is required.")]
        //[StringLength(20, ErrorMessage = "The FirstName Field must be between {2} and {1} characters long.", MinimumLength = 5)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "The LastName Field is required.")]
       // [StringLength(20, ErrorMessage = "The LastName Field must be between {2} and {1} characters long.", MinimumLength = 5)]
        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "The Password Field is required.")]
        public string Password { get; set; }
        public DateTime BirthDate { get; set; }
        public bool Gender { get; set; }

        [Required(ErrorMessage = "The Email Field is required.")]
        public string Email { get; set; }
        public string UserName { get; set; }
        public IFormFile? File { get; set; }

    }
}
