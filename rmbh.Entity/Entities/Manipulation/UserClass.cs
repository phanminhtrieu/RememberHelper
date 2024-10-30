using rmbh.Entity.Enums;

namespace rmbh.Entity.Entities.Manipulation
{
    public class UserClass : BaseEntity<int>
    {
        public Guid UserId { get; set; }
        public User? User { get; set; }

        public int ClassId { get; set; }
        public Class? Class { get; set; }

        public ClassRole Role { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}
