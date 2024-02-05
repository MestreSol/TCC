using OldBarom.Core.DLC.Domain.Entities.System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.Ativos
{
    public class Allocation : Entity
    {
        public string Name { get; private set; }
        
        

        public Allocation(string name)
        {
            Name = name;
        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Name too short");
        }
    }
}
