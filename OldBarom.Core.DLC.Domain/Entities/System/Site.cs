using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class Site
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Guid SiteOwnerID { get; private set; }
        public List<Guid> SiteSubOwner { get; private set; }
    }
}
