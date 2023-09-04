using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HotelListing.API.Data.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            builder.HasData(
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
