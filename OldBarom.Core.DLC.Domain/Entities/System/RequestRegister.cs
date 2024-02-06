using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class RequestRegister : Entity
    {
        public string Workday { get; private set; } 
        public string UserName { get; private set; }
        public string Email { get; private set; }
    }
}
