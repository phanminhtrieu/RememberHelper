using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;

namespace rmbh.Entity.Entities.Manipulation
{
    public class UserClassStatistic : BaseEntity<int>, IHasUserPerformanceTracking
    {
        public long? TimeSpent { get; set; }
        public MasteryScore? MasteryScore { get; set; }

        public int? ClassId { get; set; }
        public Class? Class { get; set; }

        public Guid? UserId { get; set; }
        public User? User { get; set; }

    }
}
