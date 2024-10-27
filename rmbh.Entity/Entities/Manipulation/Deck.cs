using rmbh.Entity.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity.Entities.Manipulation
{
    public class Deck : BaseEntity<int>, IHasDateTracking
    {
        public string? Name { get; set; }
        public string? Objective { get; set; }

        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

        public ICollection<Card>? Cards { get; set; }

        public int ClassId { get; set; }
        public Class? Class { get; set; }
    }
}
