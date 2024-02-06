using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.Solicitation
{
    public class SolicitationHistory
    {
        public int ID { get; private set; }
        public Guid SolicitationID { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
    }
}
