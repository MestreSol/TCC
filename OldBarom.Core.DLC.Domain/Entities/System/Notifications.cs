using OldBarom.Core.DLC.Domain.Entities.Ativos;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class Notifications : Entity
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public DateTime Date { get; private set; }
        public bool Read { get; private set; }
        public Guid UserID { get; private set; }

        public Notifications(string title, string description, DateTime date, bool read, Guid userID)
        {
            ValidateDomain(title, description, date, read, userID);
        }

        public Notifications(Guid id, string title, string description, DateTime date, bool read, Guid userID)
        {
            ValidateDomain(title, description, date, read, userID);
            Id = id;
        }

        private void ValidateDomain(string title, string description, DateTime date, bool read, Guid userID)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(title), "Title is required");
            DomainExceptionValidation.When(title.Length < 3 || title.Length > 100, "Title must be between 3 and 100 characters");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Description is required");
            DomainExceptionValidation.When(description.Length < 3 || description.Length > 100, "Description must be between 3 and 100 characters");

            DomainExceptionValidation.When(date == null, "Date is required");

            DomainExceptionValidation.When(userID == Guid.Empty, "User is required");

            Title = title;
            Description = description;
            Date = date;
            Read = read;
            UserID = userID;
        }
    }
}
