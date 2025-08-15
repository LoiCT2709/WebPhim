using System.ComponentModel.DataAnnotations;

namespace WebPhim.Models
{
    public class MovieGenre
    {
        [Required, StringLength(20)]
        public string MovieID { get; set; } = string.Empty;
        public Movie Movie { get; set; } = null!;

        [Required, StringLength(20)]
        public string GenreID { get; set; } = string.Empty;
        public Genre Genre { get; set; } = null!;

    }
}
