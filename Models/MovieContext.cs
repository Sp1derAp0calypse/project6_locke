using Microsoft.EntityFrameworkCore;

namespace project6.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) // Constructor
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}
