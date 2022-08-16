using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selfemployed.Service.Implementations
{
    public class GetIDRGDialogQuery
    {
        public IEnumerable<Guid> ClientIds { get; set; }
    }
}
