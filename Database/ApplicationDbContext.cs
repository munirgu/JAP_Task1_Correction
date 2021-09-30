using JAP_Task_Backend.Entities;
using JAP_Task_Backend.Extensions;
using JAP_Task_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace JAP_Task_Backend.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Video> Videos { get; set; }
        public DbSet<Actor> VideoActors { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<TopTenMoviesByRatings> TopTenMoviesByRatings { get; set; }
        public DbSet<TopTenMoviesByScreenings> TopTenMoviesByScreenings { get; set; }
        public DbSet<TopMoviesByMostSoldTickets> TopMoviesByMostSoldTickets { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            modelBuilder.Entity<TopTenMoviesByRatings>().HasNoKey().ToView("TopTenMoviesByRatings");
            modelBuilder.Entity<TopTenMoviesByScreenings>().HasNoKey().ToView("TopTenMoviesByScreenings");
            modelBuilder.Entity<TopMoviesByMostSoldTickets>().HasNoKey().ToView("TopMoviesByMostSoldTickets");
        }
    }
}
