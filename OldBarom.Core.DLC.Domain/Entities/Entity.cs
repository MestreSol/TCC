using OldBarom.Core.DLC.Domain.Entities.System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities
{
    public abstract class Entity
    {
        public Guid Id { get; protected set; }
        public int SiteId { get; protected set; }
        public Site Site { get; protected set; }
    }
}
