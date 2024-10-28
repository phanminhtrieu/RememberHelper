using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;

namespace rmbh.Entity.Entities.Manipulation
{
    public class Deck : BaseEntity<int>, IHasDateTracking, IHasSortable
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? SortOrder { get; set; }
        public StudyDeckType StudyDeckType { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public int ClassId { get; set; }
        public Class? Class { get; set; }

        public ICollection<Card>? Cards { get; set; }
        public ICollection<UserDeckStatistic>? UserDeckStatistics { get; set; }
    }
}
