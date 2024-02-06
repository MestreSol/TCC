using OldBarom.Core.DLC.Domain.Entities.Ativos;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class RequestRegister : Entity
    {
        public string Workday { get; private set; } 
        public string UserName { get; private set; }
        public string Email { get; private set; }

        public RequestRegister(string workday, string userName, string email)
        {
            ValidateDomain(workday, userName, email);
        }

        public RequestRegister(Guid id, string workday, string userName, string email)
        {
            ValidateDomain(workday, userName, email);
            Id = id;
        }

        private void ValidateDomain(string workday, string userName, string email)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(workday), "Workday is required");
            DomainExceptionValidation.When(workday.Length < 3 || workday.Length > 100, "Workday must be between 3 and 100 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(userName), "UserName is required");
            DomainExceptionValidation.When(userName.Length < 3 || userName.Length > 100, "UserName must be between 3 and 100 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(email), "Email is required");
            DomainExceptionValidation.When(email.Length < 3 || email.Length > 100, "Email must be between 3 and 100 characters");

            Workday = workday;
            UserName = userName;
            Email = email;
        }
    }
}
