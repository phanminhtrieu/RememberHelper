using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;

namespace rmbh.Entity.Entities.Manipulation
{
    public class UserClassStatistic : BaseEntity<int>, IHasDateComponents, IHasUserPerformanceTracking
    {
        public long? TimeSpent { get; set; }
        public MasteryScore? MasteryScore { get; set; }
        public int? Day { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public string? Note { get; set; }

        public int? ClassId { get; set; }
        public Class? Class { get; set; }

        public Guid? UserId { get; set; }
        public User? User { get; set; }

    }
}
