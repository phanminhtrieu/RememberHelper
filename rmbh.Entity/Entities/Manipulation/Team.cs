using rmbh.Entity.Enums;
using rmbh.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity.Entities.Manipulation
{
    public class Team : BaseEntity<int>, IHasDateTracking
    {
        public byte[]? Avatar { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public TeamStatus Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<UserTeam>? UserTeams { get; set; }
        public ICollection<TeamClass>? TeamClasses { get; set; }
    }
}
