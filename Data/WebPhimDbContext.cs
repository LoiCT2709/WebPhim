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
        }
    }
}
