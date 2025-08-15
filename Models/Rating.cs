using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhim.Models
{
    public class Rating
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string RatingID { get; set; } = string.Empty;

        [Range(1,5)]
        public int RatingValue { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        //Foreign key

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
