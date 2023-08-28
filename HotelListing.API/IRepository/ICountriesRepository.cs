using HotelListing.API.Data;

namespace HotelListing.API.IRepository
{
    public interface ICountriesRepository : IGenericRepository<Country>
    {
        Task<Country> GetDetails(int id);
    }
}
