using NUnit.Framework;
using OldBarom.Core.DLC.Domain.Entities.Ativos;
using OldBarom.Core.DLC.Domain.Entities.System;
using System;

namespace OldBarom.Core.DLC.Domain.Test
{
    public class NotificationsTests
    {
        [Test]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var title = "Test Title";
            var description = "Test Description";
            var date = DateTime.Now;
            var read = true;
            var userID = Guid.NewGuid();

            // Act
            var notification = new Notifications(title, description, date, read, userID);

            // Assert
            Assert.AreEqual(title, notification.Title);
            Assert.AreEqual(description, notification.Description);
            Assert.AreEqual(date, notification.Date);
            Assert.AreEqual(read, notification.Read);
            Assert.AreEqual(userID, notification.UserID);
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenTitleIsEmpty()
        {
            // Arrange
            var title = string.Empty;
            var description = "Test Description";
            var date = DateTime.Now;
            var read = true;
            var userID = Guid.NewGuid();

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new Notifications(title, description, date, read, userID));
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenDescriptionIsEmpty()
        {
            // Arrange
            var title = "Test Title";
            var description = string.Empty;
            var date = DateTime.Now;
            var read = true;
            var userID = Guid.NewGuid();

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new Notifications(title, description, date, read, userID));
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenUserIDIsEmpty()
        {
            // Arrange
            var title = "Test Title";
            var description = "Test Description";
            var date = DateTime.Now;
            var read = true;
            var userID = Guid.Empty;

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new Notifications(title, description, date, read, userID));
        }
    }
}
