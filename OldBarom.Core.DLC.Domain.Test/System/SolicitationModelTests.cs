using NUnit.Framework;
using OldBarom.Core.DLC.Domain.Entities.Ativos;
using OldBarom.Core.DLC.Domain.Entities.System;
using System;
using System.Collections.Generic;

namespace OldBarom.Core.DLC.Domain.Test
{
    public class SolicitationModelTests
    {
        [Test]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var name = "Test Name";
            var description = "Test Description";
            var fields = new Dictionary<string, Fields>();
            var submitFile = true;
            var form = true;
            var executeDate = DateTime.Now;

            // Act
            var solicitationModel = new SolicitationModel(name, description, fields, submitFile, form, executeDate);

            // Assert
            Assert.AreEqual(name, solicitationModel.Name);
            Assert.AreEqual(description, solicitationModel.Description);
            Assert.AreEqual(fields, solicitationModel.Fields);
            Assert.AreEqual(submitFile, solicitationModel.SubmitFile);
            Assert.AreEqual(form, solicitationModel.Form);
            Assert.AreEqual(executeDate, solicitationModel.ExecuteDate);
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenNameIsEmpty()
        {
            // Arrange
            var name = string.Empty;
            var description = "Test Description";
            var fields = new Dictionary<string, Fields>();
            var submitFile = true;
            var form = true;
            var executeDate = DateTime.Now;

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new SolicitationModel(name, description, fields, submitFile, form, executeDate));
        }

        // ... outros testes para validar as outras regras de negócio ...
    }
}
