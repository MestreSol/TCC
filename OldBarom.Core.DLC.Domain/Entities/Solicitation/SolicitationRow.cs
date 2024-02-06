using OldBarom.Core.DLC.Domain.Entities.Ativos;
using OldBarom.Core.DLC.Domain.Entities.System;

namespace OldBarom.Core.DLC.Domain.Entities.Solicitation
{
    public class SolicitationRow
    {
        public int Id { get; private set; }
        public Guid SolicitationId { get; private set; }
        public Solicitation Solicitation { get; private set; }
        public Guid EmployeeId { get; private set; }
        public Employees Employees { get; private set; }
        public Dictionary<string, string> Fields { get; private set; }
        public int StateId { get; private set; }
        public SolicitationStates State { get; private set; }
        public int SiteID { get; private set; }
        public virtual Site Site { get; private set; }
        
        public SolicitationRow(Guid solicitationId, Guid employeeId, int stateId, int siteId)
        {
            ValidateDomain(solicitationId, employeeId, stateId, siteId);
        }

        public SolicitationRow(int id, Guid solicitationId, Guid employeeId, int stateId, int siteId)
        {
            ValidateDomain(solicitationId, employeeId, stateId, siteId);
            Id = id;
        }

        private void ValidateDomain(Guid solicitationId, Guid employeeId, int stateId, int siteId)
        {
            DomainExceptionValidation.When(solicitationId == Guid.Empty, "Solicitation is required");
            DomainExceptionValidation.When(employeeId == Guid.Empty, "Employee is required");
            DomainExceptionValidation.When(stateId < 1, "State is required");
            DomainExceptionValidation.When(siteId < 1, "Site is required");

            SolicitationId = solicitationId;
            EmployeeId = employeeId;
            StateId = stateId;
            SiteID = siteId;
        }   
    }
}
