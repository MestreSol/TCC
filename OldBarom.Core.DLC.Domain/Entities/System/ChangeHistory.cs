using OldBarom.Core.DLC.Domain.Entities.Ativos;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class ChangeHistory : Entity
    {
        public Employees Employee { get; private set; }
        public Guid EmployeeID { get; private set; }

        public string Moving { get; private set; }
        public DateTime RequestDate { get; private set; }
        public DateTime AproveDate { get; private set; }
        public Guid MadeByID { get; private set; }
        public Guid AproveByID { get; private set; }
        public int SiteID { get; private set; }
        public Site Site { get; private set; }

        public ChangeHistory(Guid employeeID, string moving, DateTime requestDate, DateTime aproveDate, Guid madeByID, Guid aproveByID, int siteID)
        {
            ValidateDomain(employeeID, moving, requestDate, aproveDate, madeByID, aproveByID, siteID);
        }

        public ChangeHistory(Guid id, Guid employeeID, string moving, DateTime requestDate, DateTime aproveDate, Guid madeByID, Guid aproveByID, int siteID)
        {
            ValidateDomain(employeeID, moving, requestDate, aproveDate, madeByID, aproveByID, siteID);
            Id = id;
        }

        private void ValidateDomain(Guid employeeID, string moving, DateTime requestDate, DateTime aproveDate, Guid madeByID, Guid aproveByID, int siteID)
        {
            DomainExceptionValidation.When(employeeID == Guid.Empty, "Employee is required");
            DomainExceptionValidation.When(string.IsNullOrEmpty(moving), "Moving is required");
            DomainExceptionValidation.When(moving.Length < 3 || moving.Length > 100, "Moving must be between 3 and 100 characters");
            DomainExceptionValidation.When(requestDate == null, "Request Date is required");
            DomainExceptionValidation.When(aproveDate == null, "Aprove Date is required");
            DomainExceptionValidation.When(madeByID == Guid.Empty, "Made By is required");
            DomainExceptionValidation.When(aproveByID == Guid.Empty, "Aprove By is required");
            DomainExceptionValidation.When(siteID < 1, "Site is required");

            EmployeeID = employeeID;
            Moving = moving;
            RequestDate = requestDate;
            AproveDate = aproveDate;
            MadeByID = madeByID;
            AproveByID = aproveByID;
            SiteID = siteID;
        }
    }
}
