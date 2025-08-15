using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhim.Models
{
    public class SearchHistory
    {
        [Key]
        [StringLength(20)]
        [Required]
        public required string  SearchID {  get; set; }

        [StringLength(255)]
        public string Keyword { get; set; } = string.Empty;

        public DateTime SearchAt { get; set; } = DateTime.Now;

        [Required,StringLength (20)]
        public required string UserID    { get; set; }
        [ForeignKey("UserID")]
        public User User { get; set; } = null!;
    }
}
