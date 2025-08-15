using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhim.Models
{
    public class Comment
    {
        [Key]
        [Required]
        [StringLength(20)]
        public required string CommentID { get; set; }

        [StringLength(3000)]
        public string Content { get; set; } = string.Empty;

        public DateTime CreatAt { get; set; } = DateTime.Now;

        [StringLength(20)]
        public string ParentCommentID { get; set; } = string.Empty;

        //FOREIGN KEY
        [Required, StringLength(20)]
        public string UserID { get; set; } = string.Empty;

        [Required, StringLength(20)]
        public string MovieID { get; set; } = string.Empty;

        [ForeignKey("UserID")]
        public User User { get; set; } = null!;

        [ForeignKey("MovieID")]

        public Movie Movie { get; set; } = null!;

    }
}
