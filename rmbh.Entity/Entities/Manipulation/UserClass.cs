using rmbh.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
