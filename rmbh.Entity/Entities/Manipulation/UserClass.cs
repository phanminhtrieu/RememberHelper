using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;

namespace rmbh.Entity.Entities.Manipulation
{
    public class UserClass : BaseEntity<int>, IHasUserPerformanceTracking
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public int ClassId { get; set; }
        public Class? Class { get; set; }

        public ClassRole Role { get; set; }
        public DateTime JoinedDate { get; set; }
        public long? TimeSpent { get; set; }
        public MasteryScore? MasteryScore { get; set; }
        public DateTime LastLearningDate { get; set; }
    }
}
