using Microsoft.EntityFrameworkCore;
using rmbh.Entity;
using rmbh_backoffice.MVC.Models.Dtos.Authentications;
using rmbh_backoffice.MVC.Models.Dtos.Users;

namespace rmbh_backoffice.MVC.Models.Services.Authentications
{
    public interface IAuthenticationService
    {
        bool IsLoginSuccessful(AuthenticationRequest authenticationRequest);
        Task<UserDto> GetUserByEmail(string email);
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly AppDbContext _context;

        public AuthenticationService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<UserDto> GetUserByEmail(string email)
        {
            var user = await _context.Users
                .SingleOrDefaultAsync(u => u.Email == email);

            if (user == null)
            {
                return null; // Nếu không tìm thấy người dùng
            }

            return new UserDto
            {
                Id = user.Id, 
                Email = user.Email,
                FisrtName = user.FirstName,
                LastName = user.LastName,
                Role = user.Role,
            };
        }

        public bool IsLoginSuccessful(AuthenticationRequest authenticationRequest)
        {
            // Kiểm tra xem người dùng có tồn tại trong cơ sở dữ liệu không
            var user = _context.Users
                .SingleOrDefault(u => u.Email == authenticationRequest.Email);

            if (user != null && user.Password == authenticationRequest.Password)
            {
                return true;
            }

            return false;
        }
    }
}
