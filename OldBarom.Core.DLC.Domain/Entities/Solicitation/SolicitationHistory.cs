using OldBarom.Core.DLC.Domain.Entities.Ativos;
using OldBarom.Core.DLC.Domain.Entities.System;

namespace OldBarom.Core.DLC.Domain.Entities.Solicitation
{
    public class SolicitationHistory
    {
        public int ID { get; private set; }
        public Guid SolicitationID { get; private set; }
        public virtual Solicitation Solicitation { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public virtual Site Site { get; private set; }
        public int SiteId { get; private set; }
        public SolicitationHistory(Guid solicitationID, string description, DateTime date, int siteId)
        {
            ValidateDomain(solicitationID, description, date, siteId);
        }

        public SolicitationHistory(int id, Guid solicitationID, string description, DateTime date, int siteId)
        {
            ValidateDomain(solicitationID, description, date, siteId);
            ID = id;
        }

        private void ValidateDomain(Guid solicitationID, string description, DateTime date, int siteId)
        {
            DomainExceptionValidation.When(solicitationID == Guid.Empty, "Solicitation is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Description is required");
            DomainExceptionValidation.When(description.Length < 3 || description.Length > 100, "Description must be between 3 and 100 characters");
            DomainExceptionValidation.When(date == null, "Date is required");
            DomainExceptionValidation.When(siteId < 1, "Site is required");

            SolicitationID = solicitationID;
            Description = description;
            Date = date;
            SiteId = siteId;
        }
    }
}
