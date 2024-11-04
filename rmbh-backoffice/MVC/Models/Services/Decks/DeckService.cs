using Microsoft.EntityFrameworkCore;
using rmbh.Entity;
using rmbh.Entity.Entities.Manipulation;
using rmbh_backoffice.MVC.Models.Dtos.Decks;
using rmbh_backoffice.MVC.Models.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace rmbh_backoffice.MVC.Models.Services.Decks
{
    public interface IDeckService 
    {
        List<DeckDto> GetAll();
        int Add(DeckRequest request);
        int Update(int id, DeckRequest request);
        int Delete(int id);

        // new DeckService(hoaDb);
    }

    public class DeckService : IDeckService
    {
        private readonly AppDbContext _context;

        public DeckService() { }

        public DeckService(AppDbContext context) 
        {
            _context = context;
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
