using Microsoft.EntityFrameworkCore;
using rmbh.Entity;
using rmbh.Entity.Entities.Manipulation;
using rmbh_backoffice.MVC.Models.Dtos.Classes;

namespace rmbh_backoffice.MVC.Models.Services.Classes
{
    public interface IClassService
    {
        Task<IEnumerable<ClassDto>> GetAllClassesByUserId(string userId);
    }

    public class ClassService : IClassService
    {
        private readonly AppDbContext _context;

        public ClassService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ClassDto>> GetAllClassesByUserId(string userId)
        {
            // Lấy danh sách lớp học theo userId thông qua UserClass
            var classes = await _context.UserClasses
                .Where(uc => uc.UserId == Guid.Parse(userId)) // Lọc theo userId
                .Include(uc => uc.Class) // Thực hiện nối với bảng Classes
                .Select(uc => new ClassDto
                {
                    Id = uc.Class.Id,
                    Logo = uc.Class.Logo,
                    Title = uc.Class.Title,
                    Description = uc.Class.Description,
                    Owner = uc.User.FirstName.ToString(),
                    Role = uc.Role,
                    Visibility = uc.Class.Visibility,
                    LastLearningDate = uc.Class.LastLearningDate,
                    CreatedDate = uc.Class.CreatedDate,
                    ModifiedDate = uc.Class.ModifiedDate
                })
                .ToListAsync();

            return classes; // Trả về danh sách các ClassDto
        }
    }
}
