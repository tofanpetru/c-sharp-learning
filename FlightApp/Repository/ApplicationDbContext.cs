using Microsoft.EntityFrameworkCore;
using Persistence;
using System;

namespace Repository
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public ApplicationDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Flight>().HasData(
                new Flight { FlightId = 1, FlightDate = DateTime.Now, Departure = "Moldova", Destination = "Viena", FlightDuration = "7h 3min" });
            modelBuilder.Entity<Flight>().HasData(
                new Flight { FlightId = 2, FlightDate = DateTime.Now, Departure = "Romania", Destination = "Argentina", FlightDuration = "5h 3min" });
        }

        public DbSet<Flight> Flights { get; set; }

    }
}