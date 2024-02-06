
namespace OldBarom.Core.DLC.Domain.Entities.Ativos
{
    public class IdentityGenders : Entity
    {
        public string Name { get; private set; }
        public bool IsEnable { get; private set; }
        
        public IdentityGenders(string name, int site)
        {
            ValidateDomain(name, site);
        }

        public IdentityGenders(Guid id, string name, int site)
        {
            ValidateDomain(name, site);
            Id = id;
        }

        private void ValidateDomain(string name, int site)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3 || name.Length > 100, "Name must be between 3 and 100 characters");  
            DomainExceptionValidation.When(site < 1, "Site is required");

            Name = name;
            SiteId = site;
        }
    }
}
