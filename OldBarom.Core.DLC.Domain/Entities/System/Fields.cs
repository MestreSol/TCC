using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class Fields
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool IsEditable { get; private set; }
        public bool IsRequired { get; private set; }   
        public string Description { get; private set; }
        public bool IsVisible { get; private set; }
        public bool Minimal { get; private set; }
        public Dictionary<int, string> DefaultValues { get; private set; }
    }
}
