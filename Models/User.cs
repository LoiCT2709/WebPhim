using System.ComponentModel.DataAnnotations;

namespace WebPhim.Models
{
    public class User
    {
        [Key]
        [StringLength(20)]
        public  string? UserID { get; set; }

        [Required, StringLength(100)]
        public string? UserName { get; set; }

        [Required, StringLength(255)]
        public string? Email { get; set; }

        [Required, StringLength(255)]
        public  string? PasswordHash { get; set; }
        
        [Required, StringLength(50)]
        public  string? Role {  get; set; }

        public string? Avatar {  get; set; }

        public DateTime CreatedAt {  get; set; }

        //Status Account:
        [StringLength(50)]
        public  string? Status { get; set; }
        public bool IsVerified { get; set; }

        //Navigation
        public ICollection<SearchHistory> SearchHistories { get; set; } = new List<SearchHistory>();
        public ICollection<Favorite> Favorites { get; set; } = new List<Favorite>();
        public ICollection<View> Views { get; set; } = new List<View>();
        public ICollection<Rating> Ratings { get; set; } = new List<Rating>();
        public ICollection<WatchHistory> WatchHistories { get; set; } = new List<WatchHistory>();
        public ICollection<Comment> Comments { get; set; } = new List<Comment>();

        public User()
        {

        }


        public User(string userName, string email)
        {
            UserName = userName;
            Email = email;

            // placeholder tạm
            UserID = string.Empty;
            PasswordHash = string.Empty;
            Role = string.Empty;
            Status = string.Empty;
        }





    }
}
