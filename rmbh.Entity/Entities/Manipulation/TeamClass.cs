using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity.Entities.Manipulation
{
    public class TeamClass : BaseEntity<int>
    {
        public int TeamId { get; set; }
        public Team? Team { get; set; }
        public int ClassId { get; set; }
        public Class? Class { get; set; }
    }
}
