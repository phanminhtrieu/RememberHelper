using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity.Entities.Manipulation
{
    public class Card : BaseEntity<int>, IHasDateTracking, IHasSortable
    {
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public byte[]? QuestionImg { get; set; }
        public byte[]? AsnImg { get; set; }
        public string? QuestionClarifier { get; set; }
        public string? AnswerClarifier { get; set; }
        public string? QuestionFootnote { get; set; }
        public string? AnswerFootnote { get; set; }
        public MasteryScore MasteryScore { get; set; }
        public int? SortOrder { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public int? DeckId { get; set; }
        public Deck? Deck { get; set; }

    }
}
