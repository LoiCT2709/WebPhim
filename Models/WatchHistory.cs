using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhim.Models
{
    public class WatchHistory
    {
        [Key]
        [StringLength(20)]
        [Required]
        public  string HistoryID { get; set; } = string.Empty;

        public DateTime LastWatchedAt { get; set; } = DateTime.Now;

        public int PositionSeconds { get; set; }

        public float WatchedPercent { get; set; }

        public bool Completed { get; set; }

        //FOREIGGN KEY:
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
