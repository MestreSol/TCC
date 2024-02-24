using NUnit.Framework;
using OldBarom.Core.DLC.Domain.Entities.Ativos;
using OldBarom.Core.DLC.Domain.Entities.System;
using System;

namespace OldBarom.Core.DLC.Domain.Test
{
    public class ChangeHistoryTests
    {
        [Test]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var employeeID = Guid.NewGuid();
            var moving = "Test Moving";
            var requestDate = DateTime.Now;
            var aproveDate = DateTime.Now.AddDays(1);
            var madeByID = Guid.NewGuid();
            var aproveByID = Guid.NewGuid();
            var siteID = 1;

            // Act
            var changeHistory = new ChangeHistory(employeeID, moving, requestDate, aproveDate, madeByID, aproveByID, siteID);

            // Assert
            Assert.AreEqual(employeeID, changeHistory.EmployeeID);
            Assert.AreEqual(moving, changeHistory.Moving);
            Assert.AreEqual(requestDate, changeHistory.RequestDate);
            Assert.AreEqual(aproveDate, changeHistory.AproveDate);
            Assert.AreEqual(madeByID, changeHistory.MadeByID);
            Assert.AreEqual(aproveByID, changeHistory.AproveByID);
            Assert.AreEqual(siteID, changeHistory.SiteID);
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenEmployeeIDIsEmpty()
        {
            // Arrange
            var employeeID = Guid.Empty;
            var moving = "Test Moving";
            var requestDate = DateTime.Now;
            var aproveDate = DateTime.Now.AddDays(1);
            var madeByID = Guid.NewGuid();
            var aproveByID = Guid.NewGuid();
            var siteID = 1;

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new ChangeHistory(employeeID, moving, requestDate, aproveDate, madeByID, aproveByID, siteID));
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenMovingIsEmpty()
        {
            // Arrange
            var employeeID = Guid.NewGuid();
            var moving = string.Empty;
            var requestDate = DateTime.Now;
            var aproveDate = DateTime.Now.AddDays(1);
            var madeByID = Guid.NewGuid();
            var aproveByID = Guid.NewGuid();
            var siteID = 1;

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new ChangeHistory(employeeID, moving, requestDate, aproveDate, madeByID, aproveByID, siteID));
        }

        // ... outros testes para validar as outras regras de negócio ...
    }
}
