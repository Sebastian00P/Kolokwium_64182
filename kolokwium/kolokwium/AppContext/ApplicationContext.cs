using kolokwium.Models;
using Microsoft.EntityFrameworkCore;

namespace kolokwium.AppContext
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) :base(options)
        { 

        }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<RoomType> RoomTypes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<RoomType>().HasData(
                new RoomType { Id = 1, Name = "Pokój jednoosobowy" },
                new RoomType { Id = 2, Name = "Pokój dwuosobowy" },
                new RoomType { Id = 3, Name = "Pokój sześcioosobowy" }
            );
        }
    }
}
