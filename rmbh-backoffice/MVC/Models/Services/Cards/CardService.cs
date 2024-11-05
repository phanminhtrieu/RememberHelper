using Microsoft.EntityFrameworkCore;
using rmbh.Entity;
using rmbh_backoffice.MVC.Models.Dtos.Cards;
using rmbh_backoffice.MVC.Models.Dtos.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh_backoffice.MVC.Models.Services.Cards
{
    public interface ICardService
    {
        List<CardDto> GetAll();
        int Add(CardRequest request);
        int Update(int cardId, CardRequest request);
        int Delete(int cardId);
    }

    public class CardService : ICardService
    {
        private readonly AppDbContext _context;

        public CardService(AppDbContext context)
        {
            _context = context;
        }

        public List<CardDto> GetAll()
        {
            var query = _context.Cards.AsNoTracking();

            var cards = query.Select(x => new CardDto()
            {
                Id = x.Id,
                Question = x.Question,
                Answer = x.Answer,
                QuestionClarifier = x.QuestionClarifier,
                AnswerClarifier = x.AnswerClarifier,
                QuestionFootnote = x.QuestionFootnote,
                AnswerFootnote = x.AnswerFootnote,
                SortOrder = x.SortOrder,
                CreatedUserName = "CreatedUserName",
                ModifiedUserName = "ModifiedUserName",
                DeckName = "DeckName",
                CreatedDate = x.CreatedDate,
                ModifiedDate = x.ModifiedDate,
            }).ToList();

            return cards;
        }

        public int Add(CardRequest request)
        {
            throw new NotImplementedException();
        }

        public int Update(int cardId, CardRequest request)
        {
            throw new NotImplementedException();
        }

        public int Delete(int cardId)
        {
            throw new NotImplementedException();
        }

    }
}
