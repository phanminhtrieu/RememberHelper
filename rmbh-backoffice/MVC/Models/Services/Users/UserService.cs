using Microsoft.EntityFrameworkCore;
using rmbh.Entity;
using rmbh_backoffice.MVC.Models.Dtos.Users;

namespace rmbh_backoffice.MVC.Models.Services.Users
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        void Add();
        void Update();
        void Delete();
    }

    public class UserService : IUserService
    {   
        private readonly AppDbContext _context;

        public UserService(AppDbContext context)
        {
            _context = context;
        }

        public List<UserDto> GetAll()
        {
            var query = _context.Users.AsNoTracking();

            var users = query.Select(x => new UserDto()
            {
                FisrtName = x.FirstName,
                LastName = x.LastName,
                Email = x.Email,
                Bio = x.Bio,
                Password = x.Password,
                Role = x.Role,
                CreatedDate = x.CreatedDate,
                ModifiedDate = x.ModifiedDate,
            }).ToList();

            return users;
        }

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }
    }
}
