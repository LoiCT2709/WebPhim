using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using WebPhim.Models;

namespace WebPhim.Data
{
    public class WebPhimDbContext: DbContext
    {
        public WebPhimDbContext(DbContextOptions<WebPhimDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Favorite> Favorites { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<MovieGenre> MoviesGenres { get; set; }
        public DbSet<Rating> Rating { get; set; }
        public DbSet<SearchHistory> SearchHistory { get; set; }
        public DbSet<View> Views { get; set; }
        public DbSet<WatchHistory> WatchHistory { get; set; }
        public DbSet<Country> Country { get; set; } 

        //Cau hinh khoa chinh ket hop
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Khoa chinh ket hop
            modelBuilder.Entity<MovieGenre>()
                .HasKey(mg => new { mg.MovieID, mg.GenreID });
            base.OnModelCreating(modelBuilder);

            //Dữ liệu mẫu
            modelBuilder.Entity<Country>().HasData(
                new Country { CountryID = "US", CountryName = "United States" },
                new Country { CountryID = "UK", CountryName = "United Kingdom" }
            );

            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = "M001",
                    Title = "Inception",
                    Description = "A mind-bending thriller",
                    ReleaseDate = new DateTime(2010, 7, 16),
                    PosterURL = "/images/inception.jpg",
                    TrailerURL = "https://youtube.com/...",
                    ViewCount = 0,
                    CreateAt = new DateTime(2025, 01, 01),
                    Status = "Active",
                    VideoURL = "/videos/inception.mp4",
                    Duration = 148,
                    CountryID = "US"
                },
                new Movie
                {
                    MovieID = "M002",
                    Title = "Interstellar",
                    Description = "Exploring space and time",
                    ReleaseDate = new DateTime(2014, 11, 7),
                    PosterURL = "/images/interstellar.jpg",
                    TrailerURL = "https://youtube.com/...",
                    ViewCount = 0,
                    CreateAt = new DateTime(2025, 01, 01),
                    Status = "Active",
                    VideoURL = "/videos/interstellar.mp4",
                    Duration = 169,
                    CountryID = "US"
                }
            );

        }
    }
}
