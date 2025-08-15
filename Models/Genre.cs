
using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace WebPhim.Models
{
    public class Genre
    {
        [Key]
        [StringLength(20)]
        public required string GenreID {get; set; }

        [Required]
        [StringLength(100)]
        public string GenreName { get; set; } = string.Empty;

        //Navigation
        public ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();

    }
}
