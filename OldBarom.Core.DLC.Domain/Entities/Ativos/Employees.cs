using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.Ativos
{
    public class Employees : Entity
    {
        public string Name { get; private set; }
        public string Register { get; private set; }
        public string Workday { get; private set; }
        public Guid ContractTypeID { get;private set; }
        public virtual ContractTypes ContractType { get; private set; }
        public Guid ShiftID { get; private set; }
        public virtual Shifts Shift { get; private set; }

        public Guid CostCenterID { get; private set; }
        public virtual CostCenters CostCenter { get; private set; }

        public Guid PositionID { get; private set; }    
        public virtual Positions Position { get; private set; }

        public Guid JobProfileID { get; private set; }
        public virtual JobProfiles JobProfile { get; private set; }

        public Guid SkillID { get; private set; }
        public virtual Skills Skill { get; private set; }

        public Guid BusinessID { get; private set; }    
        public virtual Businesses Business { get; private set; }

        public Guid PrimaryOrganizationID { get; private set; }
        public virtual PrimaryOrganizations PrimaryOrganization { get; private set; }

        public Guid AllocationID { get; private set; }  
        public virtual Allocations Allocation { get; private set; }

        public Guid TypeID { get; private set; }
        public virtual Types Type { get; private set; }

        public Guid ContractorID { get; private set; }
        public virtual Contractors Contractor { get; private set; }

        public Guid CityID { get; private set; }
        public virtual Cities City { get; private set; }

        public Guid GenderID { get; private set; }
        public IdentityGenders Gender { get; private set; }

        public Guid ClockID { get; private set; }
        public virtual Clocks Clock { get; private set; }

        public Guid SupervisorDirectID { get; private set; }
        public virtual Supervisors SupervisorDirect { get; private set; }
        public Guid SupervisorWorkdayID { get; private set; }
        public virtual Supervisors SupervisorWorkday { get; private set; }
        public DateTime AdmissionDate { get; private set; }
        public DateTime? DemissionDate { get; private set; }
        public DateTime? BirthDate { get; private set; }
        public DateTime? VacationStartDate { get; private set; }
        public DateTime? EffectiveDate { get; private set; }
        public DateTime? LeaveDate { get; private set; }
        public DateTime? ReturnFromLeaveDate { get; private set; }
        public DateTime? VacationEndDate { get; private set; }
        public DateTime? GracePeriodReturnDate { get; private set; }
        public string Notes { get;private set; }
        public Guid WorkStationID { get; private set; }
        public virtual WorkStations WorkStation { get; private set; }

        public Guid LineID { get; private set; }
        public virtual Lines Line { get; private set; }
        public Guid DisabilityTypeID { get; private set; }
        public virtual DisabilityTypes DisabilityType { get; private set; }

        public Guid RestrictionTypeID { get; private set; }
        public virtual RestrictionTypes RestrictionType { get; private set; }

        public Guid TerminationReasonID { get; private set; }
        public virtual TerminationReasons TerminationReason { get; private set; }
        public Guid ODLDivision { get; private set; }
        public virtual ODLDivisions ODLDivision { get; private set; }

    }
}
