using System.ComponentModel.DataAnnotations;

namespace WebPhim.Models
{
    public class User
    {
        [Key]
        [StringLength(20)]
        public required string UserID { get; set; }

        [Required, StringLength(100)]
        public string? UserName { get; set; }

        [Required, StringLength(255)]
        public required string Email { get; set; }

        [Required, StringLength(255)]
        public required string PasswordHash { get; set; }
        
        [Required, StringLength(50)]
        public required string Role {  get; set; }

        public string? Avatar {  get; set; }

        public DateTime CreatedAt {  get; set; }

        //Status Account:
        [StringLength(50)]
        public required string Status { get; set; }
        public bool IsVerified { get; set; }

        //Navigation
        public ICollection<SearchHistory> SearchHistories { get; set; } = new List<SearchHistory>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public ICollection<View> Views { get; set; } = new List<View>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<WatchHistory> WatchHistories { get; set; } = new List<WatchHistory>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();







    }
}
