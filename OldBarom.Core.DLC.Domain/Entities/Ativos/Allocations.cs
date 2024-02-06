namespace OldBarom.Core.DLC.Domain.Entities.Ativos
{
    public class Allocations : Entity
    {
        // Propriedades da classe Allocations
        public string Name { get; private set; }
        public bool IsEnable { get; private set; }

        // Construtor para criar uma nova instância de Allocations
        public Allocations(string name, int site)
        {
            ValidateAndSetProperties(name, site);
        }

        // Construtor para criar uma instância de Allocations com um ID específico
        public Allocations(Guid id, string name, int site)
        {
            ValidateAndSetProperties(name, site);
            Id = id;
        }

        // Método privado para validar e definir as propriedades
        private void ValidateAndSetProperties(string name, int site)
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
