using AutoMapper;
using HotelListing.API.Data;
using HotelListing.API.IRepository;
using HotelListing.API.Models.User;
using Microsoft.AspNetCore.Identity;
using System.Linq.Expressions;

namespace HotelListing.API.Repository
{
    public class AuthManager : IAuthManager
    {
        private readonly IMapper _mapper;
        private readonly UserManager<ApiUser> _userManager;

        public AuthManager(IMapper mapper, UserManager<ApiUser> userManager)
        {
            this._mapper = mapper;
            this._userManager = userManager;
        }

        public async Task<IEnumerable<IdentityError>> Register(RegisterDto registerDto)
        {
            var user = _mapper.Map<ApiUser>(registerDto);
            user.UserName = registerDto.Email;

            //register user
            var result = await _userManager.CreateAsync(user,registerDto.Password);

            //assign roles for new register user
            if (result.Succeeded)
            {
                await _userManager.AddToRoleAsync(user, "User");
            }

            return result.Errors;
        }

        public async Task<bool> Login(LoginDto loginDto)
        {
            bool isValidUser = false;
            try { 
                var user = await _userManager.FindByEmailAsync(loginDto.Email);
                if(user is null)
                {
                    return default;
                }
                isValidUser = await _userManager.CheckPasswordAsync(user, loginDto.Password);
            }
            catch (Exception ex)
            {
            }
            return isValidUser;
        }
    }
}
