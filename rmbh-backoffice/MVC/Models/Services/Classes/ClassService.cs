using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using rmbh.Entity;
using rmbh.Entity.Entities.Manipulation;
using rmbh.Entity.Enums;
using rmbh_backoffice.MVC.Models.Dtos.Classes;

namespace rmbh_backoffice.MVC.Models.Services.Classes
{
    public interface IClassService
    {
        Task<IEnumerable<ClassDto>> GetAllClassesByUserId(string userId);
        Task<int> CreateAsync(ClassRequest request);
        Task<int> UpdateAsync(int classId, ClassRequest request);
        Task<int> DeleteClass(int classId);
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

        public async Task<int> CreateAsync(ClassRequest request)
        {
            int effectedRow = 0;

            var newClass = new Class
            {
                Logo = request.Logo,
                Title = request.Title,
                Description = request.Description,
                Visibility = ClassVisibility.Private,
                CreatedDate = DateTime.UtcNow,
                ModifiedDate = DateTime.UtcNow,
            };

            await _context.Classes.AddAsync(newClass);
            effectedRow = await _context.SaveChangesAsync(); 

            var userClass = new UserClass
            {
                UserId = request.CreatedUserId,
                ClassId = newClass.Id, 
                Role = ClassRole.Owner,
            };

            await _context.UserClasses.AddAsync(userClass);
            effectedRow += await _context.SaveChangesAsync();

            return effectedRow;
        }

        public async Task<int> UpdateAsync(int classId, ClassRequest request)
        {
            var existingClass = await _context.Classes.FindAsync(classId);

            if (existingClass == null)
            {
                throw new Exception("Class not found");
            }

            existingClass.Title = request.Title;
            existingClass.Description = request.Description;
            existingClass.Logo = request.Logo;
            existingClass.ModifiedDate = DateTime.UtcNow;

            _context.Classes.Update(existingClass);

            return await _context.SaveChangesAsync();
        }

        public async Task<int> DeleteClass(int classId)
        {
            var existingClass = await _context.Classes.FindAsync(classId);

            if (existingClass == null)
            {
                throw new Exception("Class not found");
            }

            _context.Classes.Remove(existingClass);
            return await _context.SaveChangesAsync();
        }
    }
}
