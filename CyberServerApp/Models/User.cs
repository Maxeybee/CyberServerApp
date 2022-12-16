
using System.ComponentModel.DataAnnotations;

namespace CyberServerApp.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "username is required")]
        [RegularExpression(@"^[^\\/:*;\.\)\(]+$", ErrorMessage = "The characters ':', '.' ';', '*', '/' and '\' are not allowed")]
        [StringLength(maximumLength:20, MinimumLength = 3)]
        public string? Username { get; set; }

        [Required(ErrorMessage = "email is required")]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string? Email { get; set; }

        [RegularExpression("([0-9]+)", ErrorMessage = "This field must contain only numeric characters")]
        [MaxLength(20)]
        public string? Phone { get; set; }

        [Required]
        [MinLength(10, ErrorMessage = "This field must contain at least 10 characters")]
        public string? Password { get; set; }

        

    }
}
