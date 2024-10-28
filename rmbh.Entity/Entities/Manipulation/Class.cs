using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;

namespace rmbh.Entity.Entities.Manipulation
{
    public class Class : BaseEntity<int>, IHasDateTracking
    {
        // Basic infomation
        public byte[]? Logo { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public ClassVisibility Visibility { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<Deck>? Decks { get; set; }
        public ICollection<UserClass>? UserClasses { get; set; }
    }
}
