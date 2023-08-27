using HotelListingAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext : DbContext
    {
        //connect to database using options
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seeding data
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Australia",
                    ShortName = "AU",
                },
                new Country
                {
                    Id = 2,
                    Name = "Japan",
                    ShortName = "JP",
                },
                new Country
                {
                    Id = 3,
                    Name = "American",
                    ShortName = "USA",
                }
            );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                    Id = 1,
                    Name = "Grand Hotel",
                    Rating = 4.8,
                    Address = "SA 5000 Adelaide",
                    CountryId = 1
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Staford Hotel",
                    Rating = 4.6,
                    Address = "Toykon city center",
                    CountryId = 2
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Sofe Hotel",
                    Rating = 4.3,
                    Address = "NewYork city center",
                    CountryId = 3
                }
            );
        }
    }
}
