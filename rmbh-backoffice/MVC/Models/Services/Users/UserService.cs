using Microsoft.EntityFrameworkCore;
using rmbh.Entity;
using rmbh.Entity.Entities.Manipulation;
using rmbh_backoffice.MVC.Models.Dtos.Users;
using System.Data;

namespace rmbh_backoffice.MVC.Models.Services.Users
{
    public interface IUserService
    {
        List<UserDto> GetAll();
        int GetNumberOfRecords();
        int Add(UserRequest request);
        int Update(Guid userId, UserRequest request);
        int Delete(Guid userId);
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
                Id = x.Id,
                FisrtName = x.FirstName,
                LastName = x.LastName,
                Avatar = x.Avatar,
                Email = x.Email,
                Bio = x.Bio,
                Password = x.Password,
                Role = x.Role,
                CreatedDate = x.CreatedDate,
                ModifiedDate = x.ModifiedDate,
            }).ToList();

            return users;
        }

        public int GetNumberOfRecords()
        {
            var query = _context.Users.AsNoTracking();

            return query.Count();
        }

        public int Add(UserRequest request)
        {
            var user = new User() 
            {
                Avatar = request.Avatar,
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Password = request.Password,
                Bio = request.Bio,
                Role = request.Role,
                CreatedDate = request.CreatedDate,
                ModifiedDate = request.ModifiedDate,
            };

            _context.Users.Add(user);

            return _context.SaveChanges();
        }

        public int Update(Guid userId, UserRequest request)
        {
            var user = _context.Users.Find(userId);

            if (user == null)
            {
                // Message system
                return -1;
            }

            user.Id = request.Id;
            user.Avatar = request.Avatar;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Password = request.Password;
            user.Bio = request.Bio;
            user.Role = request.Role;
            user.CreatedDate = request.CreatedDate;
            user.ModifiedDate = request.ModifiedDate;

            _context.Update(user);

            return _context.SaveChanges();
        }

        public int Delete(Guid userId)
        {
            var user = _context.Users.Find(userId);

            if (user != null)
            {
                _context.Users.Remove(user);
            }

           return _context.SaveChanges();
        }
    }
}
