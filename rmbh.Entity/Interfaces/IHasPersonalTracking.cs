using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rmbh.Entity.Interfaces
{
    public interface IHasPersonTracking
    {
        Guid CreatedUserId { set; get; }
        Guid ModifiedUserId { set; get; }
    }
}
