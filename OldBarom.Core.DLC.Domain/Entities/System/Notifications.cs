using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class Notifications : Entity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public bool Read { get; private set; }
        public Guid UserID { get; private set; }
    }
}
