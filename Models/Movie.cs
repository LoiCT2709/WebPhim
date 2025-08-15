using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebPhim.Models
{
    public class Movie
    {
        [Key]
        [StringLength(20)]
        public required string MovieID { get; set; }

        //Title movie
        [StringLength(255)]
        [Required]
        public required string Title {  get; set; }
        //Description
        public required string Description { get; set; }
        //ReleaseDate
        [Required]
        public DateTime ReleaseDate { get; set; }
        //Link poster movie
        public string PosterURL { get; set; } = string.Empty;
        // Link trailerURL:
        public string TrailerURL {  get; set; } = string.Empty;

        //Range of view:
        public int ViewCount { get; set; } = 0;

        //CreateAt:
        [Required]
        public DateTime CreateAt { get; set; } = DateTime.Now;

        [StringLength(50)]
        public required string Status { get; set; }

        [Required]
        public required string VideoURL { get; set; }
        
        //Duration:
        public required int Duration { get; set; }

        //Foreign key:
        [Required,StringLength(20)]
        public required string CountryID { get; set; }

        [ForeignKey("CountryID")]
        public Country Country { get; set; } = null!;

        //Navigation
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<View> Views { get; set; } = new List<View>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public ICollection<WatchHistory> WatchHistories { get; set; } = new List<WatchHistory>();
        public ICollection<Comment>Comments { get; set; } = new List<Comment>();
        public ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();



        


    }
}
