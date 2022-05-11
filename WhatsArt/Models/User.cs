using System.ComponentModel.DataAnnotations;

namespace WhatsArt.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; } 
        [Required] 
        public string Name { get; set; }
        [Required]
        [Display(Name ="E-Mail Address")]
        public string Email { get; set; }
        [Required]
        public string Password{ get; set; }
    }
}