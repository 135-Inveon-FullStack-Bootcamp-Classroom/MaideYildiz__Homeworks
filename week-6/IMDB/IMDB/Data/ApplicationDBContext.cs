using IMDB.Entities;
using Microsoft.EntityFrameworkCore;

namespace IMDB
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<CrewMovie>().HasKey(mc => new { mc.CrewId, mc.MovieId });

            //modelBuilder.Entity<CrewMovie>()
            //    .HasOne<Movie>(m => m.movie)
            //    .WithMany(m => m.MovieActors)
            //    .HasForeignKey(mc => mc.MovieId);


            //modelBuilder.Entity<CrewMovie>()
            //    .HasOne<Crew>(c => c.crew)
            //    .WithMany(a => a.MovieActors)
            //    .HasForeignKey(mc => mc.CrewId);
            ////
            //modelBuilder.Entity<LocationMovie>().HasKey(lm => new { lm.LocationId, lm.MovieId });

            //modelBuilder.Entity<LocationMovie>()
            //    .HasOne<Movie>(m => m.movie)
            //    .WithMany(m => m.MovieLocations)
            //    .HasForeignKey(mc => mc.MovieId);


            //modelBuilder.Entity<LocationMovie>()
            //    .HasOne<Location>(c => c.location)
            //    .WithMany(a => a.MovieLocations)
            //    .HasForeignKey(mc => mc.LocationId);
            ////
            //modelBuilder.Entity<ReviewMovie>().HasKey(rm => new { rm.ReviewId, rm.MovieId });

            //modelBuilder.Entity<ReviewMovie>()
            //    .HasOne<Movie>(m => m.movie)
            //    .WithMany(m => m.MovieReviews)
            //    .HasForeignKey(mc => mc.MovieId);


            //modelBuilder.Entity<ReviewMovie>()
            //    .HasOne<Review>(c => c.review)
            //    .WithMany(a => a.MovieReviews)
            //    .HasForeignKey(mc => mc.ReviewId);
        }
        //public DbSet<CrewMovie> CrewMovies { get; set; }
        //public DbSet<LocationMovie> LocationMovies { get; set; }
        //public DbSet<ReviewMovie> ReviewMovies { get; set; }
        public DbSet<Movie> Movies { get;set;}
        public DbSet<Crew> Crew { get;set;}
        public DbSet<Location> Location { get;set;}
        public DbSet<Review> Review { get;set;}
    }
}
