using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.Solicitation
{
    public class Solicitation : Entity
    {
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public int StateID { get; private set; }
        public virtual SolicitationStates State { get; private set; }
        public Guid SolicitationID { get; private set; }
        public string Description { get; private set; }
    }
}
