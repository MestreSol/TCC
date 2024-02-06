using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.Ativos
{
    public class Types : Entity
    {
        public string Name { get; private set; }
        public bool IsEnable { get; private set; }
        public Types(string name, int site)
        {
            ValidateDomain(name, site);
        }

        public Types(Guid id, string name, int site)
        {
            ValidateDomain(name, site);
            Id = id;
        }

        private void ValidateDomain(string name, int site)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Name too short");
            DomainExceptionValidation.When(name.Length > 100, "Name too long");
            DomainExceptionValidation.When(site < 1, "Site is required");

            Name = name;
            SiteId = site;
        }
    }
}
