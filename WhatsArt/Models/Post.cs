using System.ComponentModel.DataAnnotations;

namespace WhatsArt.Models
{
    public class Post
    {
        [Key]
        public int Id { get; set; } 
        [Required] 
        public string Description { get; set; }
        [Required]
        public string Picture { get; set; }

        public string EventId { get; set; }
    }
}