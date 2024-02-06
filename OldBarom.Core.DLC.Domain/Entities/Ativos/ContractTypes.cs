
namespace OldBarom.Core.DLC.Domain.Entities.Ativos
{
    public class ContractTypes : Entity
    {
        public string Name { get; private set; }
        public bool IsEnable { get; private set; }

        public ContractTypes(string name, int site)
        {
            ValidateDomain(name, site);
        }

        public ContractTypes(Guid id, string name, int site)
        {
            ValidateDomain(name, site);
            Id = id;
        }

        private void ValidateDomain(string name, int site)
        {
            // Validação do nome
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3 || name.Length > 100, "Name must be between 3 and 100 characters");

            // Validação do site
            DomainExceptionValidation.When(site < 1, "Site is required");

            // Definição das propriedades
            Name = name;
            SiteId = site;
        }
    }
}
