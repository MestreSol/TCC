using OldBarom.Core.DLC.Domain.Entities.Ativos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public SolicitationRow(Guid solicitationId, Guid employeeId, Dictionary<string, string> fields, int stateId)
        {
            ValidationDomain(solicitationId, employeeId, fields, stateId);
        }

        public void ValidationDomain(Guid soliciationId, Guid employeeId, Dictionary<string, string> fields, int stateId)
        {
            DomainExceptionValidation.When(soliciationId == Guid.Empty, "Invalid SolicitationID");
            DomainExceptionValidation.When(employeeId == Guid.Empty, "Invalid EmployeeID");
            DomainExceptionValidation.When(fields == null, "Invalid Fields");
            DomainExceptionValidation.When(fields.Count <= 0, "Invalid Fields");
            DomainExceptionValidation.When(stateId <= 0, "Invalid StateID");

            SolicitationId = soliciationId;
            EmployeeId = employeeId;
            this.Fields = fields;
            StateId = stateId;
        }
    }
}
