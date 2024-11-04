using Microsoft.EntityFrameworkCore;
using rmbh.Entity;
using rmbh_backoffice.MVC.Models.Dtos.Decks;

namespace rmbh_backoffice.MVC.Models.Services.Decks
{
    public interface IDeckService 
    {
        List<DeckDto> GetAll();
        Task<IEnumerable<DeckDto>> GetAllDecksByClassId(int classId);
        int Add(DeckRequest request);
        int Update(int id, DeckRequest request);
        int Delete(int id);

        // new DeckService(hoaDb);
    }

    public class DeckService : IDeckService
    {
        private readonly AppDbContext _context;

        public DeckService(AppDbContext context) 
        {
            _context = context;
        }

        public async Task<IEnumerable<DeckDto>> GetAllDecksByClassId(int classId)
        {
            // Lấy danh sách Decks theo classId từ cơ sở dữ liệu
            var decks = await _context.Decks
                .Where(deck => deck.ClassId == classId)
                .Select(deck => new DeckDto
                {
                    Id = deck.Id,
                    Title = deck.Title,
                    Description = deck.Description,
                    StudyMode = deck.StudyDeckType,
                })
                .ToListAsync();

            return decks;
        }


        public List<DeckDto> GetAll()
        {
            var query = _context.Decks.AsNoTracking();

            // bien query thanh Dto
            List<DeckDto> decks = query.Select(deck => new DeckDto()
            {
               Id =  deck.Id,
               Title = deck.Title,
               ClassTitle = "ClassTitle",
               SortOrder = deck.SortOrder,
               StudyMode = deck.StudyDeckType,
               CreatedDate = deck.CreatedDate,
               ModifiedDate = deck.ModifiedDate,
            }).ToList();

            return decks;
        }

        public int Add(DeckRequest request)
        {
            throw new NotImplementedException();
        }

        public int Update(int id, DeckRequest request)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
