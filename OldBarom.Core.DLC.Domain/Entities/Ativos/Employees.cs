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
        public Guid ODLDivisionID { get; private set; }
        public virtual ODLDivisions ODLDivision { get; private set; }
        public DateTime ContractRenovation { get; private set; }
        public Dictionary<string, string> ExtraFilds { get; private set; }
        public Employees(string name)
        {
            ValidateDomain(name);   
        }
        public void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Name too short");
            DomainExceptionValidation.When(name.Length > 100, "Name too long");
            Name = name;
        }

        public Employees(string name, string register, string workday, Guid contractTypeID, Guid shiftID, Guid costCenterID, Guid positionID, Guid jobProfileID, Guid skillID, Guid businessID, Guid primaryOrganizationID, Guid allocationID, Guid typeID, Guid contractorID, Guid cityID, Guid genderID, Guid clockID, Guid supervisorDirectID, Guid supervisorWorkdayID, DateTime admissionDate, DateTime? demissionDate, DateTime? birthDate, DateTime? vacationStartDate, DateTime? effectiveDate, DateTime? leaveDate, DateTime? returnFromLeaveDate, DateTime? vacationEndDate, DateTime? gracePeriodReturnDate, string notes, Guid workStationID, Guid lineID, Guid disabilityTypeID, Guid restrictionTypeID, Guid terminationReasonID, Guid oDLDivisionID, DateTime contractRenovation, Dictionary<string, string> extraFilds)
        {
            ValidateDomain(name);
            Name = name;
            Register = register;
            Workday = workday;
            ContractTypeID = contractTypeID;
            ShiftID = shiftID;
            CostCenterID = costCenterID;
            PositionID = positionID;
            JobProfileID = jobProfileID;
            SkillID = skillID;
            BusinessID = businessID;
            PrimaryOrganizationID = primaryOrganizationID;
            AllocationID = allocationID;
            TypeID = typeID;
            ContractorID = contractorID;
            CityID = cityID;
            GenderID = genderID;
            ClockID = clockID;
            SupervisorDirectID = supervisorDirectID;
            SupervisorWorkdayID = supervisorWorkdayID;
            AdmissionDate = admissionDate;
            DemissionDate = demissionDate;
            BirthDate = birthDate;
            VacationStartDate = vacationStartDate;
            EffectiveDate = effectiveDate;
            LeaveDate = leaveDate;
            ReturnFromLeaveDate = returnFromLeaveDate;
            VacationEndDate = vacationEndDate;
            GracePeriodReturnDate = gracePeriodReturnDate;
            Notes = notes;
            WorkStationID = workStationID;
            LineID = lineID;
            DisabilityTypeID = disabilityTypeID;
            RestrictionTypeID = restrictionTypeID;
            TerminationReasonID = terminationReasonID;
            ODLDivisionID = oDLDivisionID;
            ContractRenovation = contractRenovation;
            ExtraFilds = extraFilds;
        }
    }
}
