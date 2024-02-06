using OldBarom.Core.DLC.Domain.Entities.Ativos;

namespace OldBarom.Core.DLC.Domain.Entities.Solicitation
{
    public class Solicitation : Entity
    {
        public string Name { get; private set; }
        public DateTime Date { get; private set; }
        public int StateID { get; private set; }
        public virtual SolicitationStates State { get; private set; }
        public Guid SolicitationID { get; private set; }
        public string Description { get; private set; }

        public Solicitation(string name, int siteId, DateTime date, int stateID, string description)
        {
            ValidateDomain(name, siteId, date, stateID, description);
        }

        public Solicitation(Guid id, int siteId, string name, DateTime date, int stateID, string description)
        {
            ValidateDomain(name, siteId, date, stateID, description);
            Id = id;
        }

        public void ValidateDomain(string name, int siteId, DateTime date, int stateID, string description)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3 || name.Length > 100, "Name must be between 3 and 100 characters");

            DomainExceptionValidation.When(date == null, "Date is required");

            DomainExceptionValidation.When(stateID < 1, "State is required");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Description is required");
            DomainExceptionValidation.When(description.Length < 3 || description.Length > 100, "Description must be between 3 and 100 characters");

            DomainExceptionValidation.When(siteId < 1, "Site is required");

            Name = name;
            Date = date;
            StateID = stateID;
            Description = description;
            SiteId = siteId;
        }
    }
}
