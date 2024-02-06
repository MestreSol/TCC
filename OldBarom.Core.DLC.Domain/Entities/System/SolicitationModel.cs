using OldBarom.Core.DLC.Domain.Entities.Ativos;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class SolicitationModel: Entity
    {
        public string Name { get; private set; }   
        public string Description { get; private set; }
        public Dictionary<string, Fields> Fields { get; private set; }
        public bool SubmitFile { get; private set; }
        public bool Form { get; private set; }
        public DateTime ExecuteDate { get; private set; }

        public SolicitationModel(string name, string description, Dictionary<string, Fields> fields, bool submitFile, bool form, DateTime executeDate)
        {
            ValidateDomain(name, description, fields, submitFile, form, executeDate);
        }

        public SolicitationModel(Guid id, string name, string description, Dictionary<string, Fields> fields, bool submitFile, bool form, DateTime executeDate)
        {
            ValidateDomain(name, description, fields, submitFile, form, executeDate);
            Id = id;
        }

        private void ValidateDomain(string name, string description, Dictionary<string, Fields> fields, bool submitFile, bool form, DateTime executeDate)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3 || name.Length > 100, "Name must be between 3 and 100 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Description is required");
            DomainExceptionValidation.When(description.Length < 3 || description.Length > 100, "Description must be between 3 and 100 characters");

            DomainExceptionValidation.When(fields == null, "Fields is required");

            Name = name;
            Description = description;
            Fields = fields;
            SubmitFile = submitFile;
            Form = form;
            ExecuteDate = executeDate;
        }
    }
}
