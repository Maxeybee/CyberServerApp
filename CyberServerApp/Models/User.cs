
using System.ComponentModel.DataAnnotations;

namespace CyberServerApp.Models
{
    [Index(nameof(Email), IsUnique = true)]
    public class User
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "username is required")]
        [StringLength(maximumLength:20, MinimumLength = 3)]
        public string Username { get; set; }

        [Required(ErrorMessage = "email is required")]
        [StringLength(maximumLength: 50, MinimumLength = 3)]
        public string Email { get; set; }

        [MaxLength(10)]
        public int? Phone { get; set; }

    }
}
