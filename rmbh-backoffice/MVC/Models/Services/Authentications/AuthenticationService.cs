using Microsoft.EntityFrameworkCore;
using rmbh.Entity;
using rmbh_backoffice.MVC.Models.Dtos.Authentications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.MVC.Models.Services.Authentications
{
    public interface IAuthenticationService
    {
        bool IsLoginSuccessful(AuthenticationRequest authenticationRequest);
    }

    public class AuthenticationService : IAuthenticationService
    {
        private readonly AppDbContext _context;

        public AuthenticationService(AppDbContext context)
        {
            _context = context;
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
