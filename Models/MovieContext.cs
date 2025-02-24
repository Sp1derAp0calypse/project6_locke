using Microsoft.EntityFrameworkCore;

namespace project6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) // Constructor
        {
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Categories> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasOne(m => m.CategoryName)  // Navigation Property
                .WithMany()                    // No inverse navigation
                .HasForeignKey(m => m.CategoryId)  // Explicit FK
                .OnDelete(DeleteBehavior.Cascade); // Adjust deletion behavior

            base.OnModelCreating(modelBuilder);
        }

    }
}
