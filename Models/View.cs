using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhim.Models
{
    public class View
    {
        [Key]
        [Required]
        [StringLength(20)]
        public required string ViewID { get; set; }

        public DateTime ViewAt { get; set; } = DateTime.Now;

        [StringLength(100)]
        public string SessionID { get; set; } = String.Empty;

        public string IP {  get; set; } =string.Empty;

        //Foreign key

        [Required, StringLength(20)]
        public string UserID { get; set; } = string.Empty;

        [Required, StringLength(20)]
        public string MovieID {  get; set; } = string.Empty;

        [ForeignKey("UserID")]
        public User User { get; set; } = null!;

        [ForeignKey("MovieID")]

        public Movie Movie { get; set; } = null!;

       
    }
}
