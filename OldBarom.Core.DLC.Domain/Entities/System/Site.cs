using OldBarom.Core.DLC.Domain.Entities.Ativos;

namespace OldBarom.Core.DLC.Domain.Entities.System
{
    public class Site
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Guid SiteOwnerID { get; private set; }
        public List<Guid> SiteSubOwner { get; private set; }

        public Site(string name, Guid siteOwnerID, List<Guid> siteSubOwner)
        {
            ValidateDomain(name, siteOwnerID, siteSubOwner);
        }

        public Site(int id, string name, Guid siteOwnerID, List<Guid> siteSubOwner)
        {
            ValidateDomain(name, siteOwnerID, siteSubOwner);
            Id = id;
        }

        private void ValidateDomain(string name, Guid siteOwnerID, List<Guid> siteSubOwner)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3 || name.Length > 100, "Name must be between 3 and 100 characters");

            DomainExceptionValidation.When(siteOwnerID == Guid.Empty, "SiteOwnerID is required");

            Name = name;
            SiteOwnerID = siteOwnerID;
            SiteSubOwner = siteSubOwner;
        }
    }
}
