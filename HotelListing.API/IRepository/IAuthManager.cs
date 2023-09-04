using HotelListing.API.Models.User;
using Microsoft.AspNetCore.Identity;

namespace HotelListing.API.IRepository
{
    public interface IAuthManager
    {
        Task<IEnumerable<IdentityError>> Register(RegisterDto registerDto);

        Task<bool> Login(LoginDto loginDto);
    }
}
