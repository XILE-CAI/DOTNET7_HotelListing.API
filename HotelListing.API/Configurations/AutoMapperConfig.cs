using AutoMapper;
using HotelListing.API.Models.Country;
using HotelListing.API.Models.Hotel;
using HotelListing.API.Data;

namespace HotelListing.API.Configurations
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<Country,CreateCountryDto>().ReverseMap();
            CreateMap<Country,GetCountryDto>().ReverseMap();
            CreateMap<Country,GetCountryDetailsDto>().ReverseMap();
            CreateMap<Country,UpdateCountryDto>().ReverseMap();

            CreateMap<Hotel, HotelDto>().ReverseMap();
        }
    }
}
