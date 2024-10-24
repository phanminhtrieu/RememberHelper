using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity.Interfaces
{
    public interface IHasSortable
    {
        int? SortOrder { get; set; }
    }
}
