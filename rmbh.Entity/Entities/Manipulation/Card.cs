using rmbh.Entity.Interfaces;

namespace rmbh.Entity.Entities.Manipulation
{
    public class Card : BaseEntity<int>, IHasDateTracking, IHasSortable, IHasPersonTracking
    {
        public string? Question { get; set; }
        public string? Answer { get; set; }
        public byte[]? QuestionImg { get; set; }
        public byte[]? AnswerImg { get; set; }
        public string? QuestionClarifier { get; set; }
        public string? AnswerClarifier { get; set; }
        public string? QuestionFootnote { get; set; }
        public string? AnswerFootnote { get; set; }
        public int? SortOrder { get; set; }
        
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public Guid CreatedUserId { get; set; }
        public Guid ModifiedUserId { get; set; }

        public int? DeckId { get; set; }
        public Deck? Deck { get; set; }

        public ICollection<UserCardStatistic>? UserCardStatistics { get; set; }
    }
}
