using rmbh.Entity;

namespace rmbh_backoffice.MVC.Models.Services.Classes
{
    public interface IClassService
    {

    }

    public class ClassService : IClassService
    {
        private readonly AppDbContext _context;

        public ClassService(AppDbContext context)
        {
            _context = context;
        }
    }
}
