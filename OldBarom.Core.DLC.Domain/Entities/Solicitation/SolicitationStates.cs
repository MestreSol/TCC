using OldBarom.Core.DLC.Domain.Entities.Ativos;

namespace OldBarom.Core.DLC.Domain.Entities.Solicitation
{
    public class SolicitationStates
    {
        public int ID { get; private set; }
        public string Name { get; private set; }

        public SolicitationStates(int id, string name)
        {
            ValidateDomain(id, name);
        }

        private void ValidateDomain(int id, string name)
        {
            DomainExceptionValidation.When(id < 1, "ID is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3 || name.Length > 100, "Name must be between 3 and 100 characters");

            ID = id;
            Name = name;
        }
    }
}
