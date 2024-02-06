using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class SolicitationModel: Entity
    {
        public string Name { get; private set; }   
        public string Description { get; private set; }
        public Dictionary<string, Fields> Fields { get; private set; }
        public bool SubmitFile { get; private set; }
        public bool Form { get; private set; }
        public DateTime ExecuteDate { get; private set; }
    }
}
