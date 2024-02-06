using OldBarom.Core.DLC.Domain.Entities.Ativos;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class Fields
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public bool IsEditable { get; private set; }
        public bool IsRequired { get; private set; }   
        public string Description { get; private set; }
        public bool IsVisible { get; private set; }
        public bool Minimal { get; private set; }
        public Dictionary<int, string> DefaultValues { get; private set; }

        public Fields(string name, bool isEditable, bool isRequired, string description, bool isVisible, bool minimal, Dictionary<int, string> defaultValues)
        {
            ValidateDomain(name, isEditable, isRequired, description, isVisible, minimal, defaultValues);
        }

        public Fields(int id, string name, bool isEditable, bool isRequired, string description, bool isVisible, bool minimal, Dictionary<int, string> defaultValues)
        {
            ValidateDomain(name, isEditable, isRequired, description, isVisible, minimal, defaultValues);
            Id = id;
        }

        private void ValidateDomain(string name, bool isEditable, bool isRequired, string description, bool isVisible, bool minimal, Dictionary<int, string> defaultValues)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3 || name.Length > 100, "Name must be between 3 and 100 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Description is required");
            DomainExceptionValidation.When(description.Length < 3 || description.Length > 100, "Description must be between 3 and 100 characters");
            
            DomainExceptionValidation.When(defaultValues.Count < 1, "DefaultValues is required");
            Name = name;
            IsEditable = isEditable;
            IsRequired = isRequired;
            Description = description;
            IsVisible = isVisible;
            Minimal = minimal;
            DefaultValues = defaultValues;
        }
    }
}
