using NUnit.Framework;
using OldBarom.Core.DLC.Domain.Entities.Ativos;
using OldBarom.Core.DLC.Domain.Entities.System;
using System;

namespace OldBarom.Core.DLC.Domain.Test
{
    public class RequestRegisterTests
    {
        [Test]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var workday = "Test Workday";
            var userName = "Test User";
            var email = "testuser@example.com";

            // Act
            var requestRegister = new RequestRegister(workday, userName, email);

            // Assert
            Assert.AreEqual(workday, requestRegister.Workday);
            Assert.AreEqual(userName, requestRegister.UserName);
            Assert.AreEqual(email, requestRegister.Email);
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenWorkdayIsEmpty()
        {
            // Arrange
            var workday = string.Empty;
            var userName = "Test User";
            var email = "testuser@example.com";

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new RequestRegister(workday, userName, email));
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenUserNameIsEmpty()
        {
            // Arrange
            var workday = "Test Workday";
            var userName = string.Empty;
            var email = "testuser@example.com";

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new RequestRegister(workday, userName, email));
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenEmailIsEmpty()
        {
            // Arrange
            var workday = "Test Workday";
            var userName = "Test User";
            var email = string.Empty;

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new RequestRegister(workday, userName, email));
        }
    }
}