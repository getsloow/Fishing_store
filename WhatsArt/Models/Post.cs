using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WhatsArt.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string PostDescription { get; set; }
        [Required]
        public string PostImage { get; set; }
        public int UserId { get; set; }
        public User User{ get; set; }
    }
}