using IMDB_clone.Entities;
using Microsoft.EntityFrameworkCore;

namespace IMDB_clone.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Crew> Crew { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Review> Review { get; set; }
    }
}
