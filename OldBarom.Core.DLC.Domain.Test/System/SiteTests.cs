using NUnit.Framework;
using OldBarom.Core.DLC.Domain.Entities.Ativos;
using OldBarom.Core.DLC.Domain.Entities.System;
using System;
using System.Collections.Generic;

namespace OldBarom.Core.DLC.Domain.Test
{
    public class SiteTests
    {
        [Test]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var name = "Test Site";
            var siteOwnerID = Guid.NewGuid();
            var siteSubOwner = new List<Guid> { Guid.NewGuid(), Guid.NewGuid() };

            // Act
            var site = new Site(name, siteOwnerID, siteSubOwner);

            // Assert
            Assert.AreEqual(name, site.Name);
            Assert.AreEqual(siteOwnerID, site.SiteOwnerID);
            Assert.AreEqual(siteSubOwner, site.SiteSubOwner);
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenNameIsEmpty()
        {
            // Arrange
            var name = string.Empty;
            var siteOwnerID = Guid.NewGuid();
            var siteSubOwner = new List<Guid> { Guid.NewGuid(), Guid.NewGuid() };

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new Site(name, siteOwnerID, siteSubOwner));
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenSiteOwnerIDIsEmpty()
        {
            // Arrange
            var name = "Test Site";
            var siteOwnerID = Guid.Empty;
            var siteSubOwner = new List<Guid> { Guid.NewGuid(), Guid.NewGuid() };

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new Site(name, siteOwnerID, siteSubOwner));
        }

        // ... outros testes para validar as outras regras de negócio ...
    }
}
