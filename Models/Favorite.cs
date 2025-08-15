using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhim.Models
{
    public class Favorite
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string FavoriteID { get; set; } = string.Empty;

        public DateTime AddAt { get; set; } = DateTime.Now;

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
