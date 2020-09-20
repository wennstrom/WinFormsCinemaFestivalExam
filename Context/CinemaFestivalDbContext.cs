
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
namespace CinemaClassLibrary
{
    public class CinemaFestivalDbContext : DbContext
    {
        public CinemaFestivalDbContext()
            : base ("FestivalDb")
        {

        }
        public DbSet<Customer> Costumers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<Saloon> Saloons { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {        
                
        }


    }
}
