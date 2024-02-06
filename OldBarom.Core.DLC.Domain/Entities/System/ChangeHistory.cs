using OldBarom.Core.DLC.Domain.Entities.Ativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class ChangeHistory : Entity
    {
        public Employees Employee { get; private set; }
        public Guid EmployeeID { get; private set; }

        public string Moving { get; private set; }
        public DateTime RequestDate { get; private set; }
        public DateTime AproveDate { get; private set; }
        public Guid MadeByID { get; private set; }
        public Guid AproveByID { get; private set; }
    }
}
