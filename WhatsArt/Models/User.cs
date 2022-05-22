using System.ComponentModel.DataAnnotations;

namespace WhatsArt.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "E-Mail Address")]
        public string UserEmail { get; set; }
        [Required]
        public string UserPassword { get; set; }




        public ICollection<Post> Posts{ get; set; }

    }
}