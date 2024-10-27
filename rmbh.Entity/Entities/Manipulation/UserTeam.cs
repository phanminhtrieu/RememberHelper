using rmbh.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity.Entities.Manipulation
{
    public class UserTeam : BaseEntity<int>
    {
        public DateTime JoinedDate { get; set; }
        public TeamRole Role { get; set; }

        public Guid UserId { get; set; }
        public User? User { get; set; }
        public int TeamId { get; set; }
        public Team? Team { get; set; }
    }
}
