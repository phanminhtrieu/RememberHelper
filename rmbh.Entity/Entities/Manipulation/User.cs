using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;

namespace rmbh.Entity.Entities.Manipulation
{
    public class User :  IHasDateTracking
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public byte[]? Avatar { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Bio { get; set; }
        public string? Password { get; set; }
        public UserRole Role { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<UserClass>? UserClasses { get; set; }
        public ICollection<UserClassStatistic>? UserClassStatistics { get; set; }
        public ICollection<UserDeckStatistic>? UserDeckStatistics { get; set; }
        public ICollection<UserCardStatistic>? UserCardStatistics { get; set; }
    }
}
