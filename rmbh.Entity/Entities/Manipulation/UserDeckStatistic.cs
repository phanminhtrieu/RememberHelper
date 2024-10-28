using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;

namespace rmbh.Entity.Entities.Manipulation
{
    public class UserDeckStatistic : BaseEntity<int>, IHasUserPerformanceTracking, IHasDateComponents
    {
        public long? TimeSpent { get; set; }
        public MasteryScore? MasteryScore { get; set; }
        public int? Day { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string? Note { get; set; }

        public int DeckId { get; set; }
        public Deck? Deck { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }
    }
}
