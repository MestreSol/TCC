using NUnit.Framework;
using OldBarom.Core.DLC.Domain.Entities.Ativos;
using OldBarom.Core.DLC.Domain.Entities.System;
using System;
using System.Collections.Generic;

namespace OldBarom.Core.DLC.Domain.Test
{
    public class FieldsTests
    {
        [Test]
        public void Constructor_ShouldSetPropertiesCorrectly()
        {
            // Arrange
            var name = "Test Name";
            var isEditable = true;
            var isRequired = false;
            var description = "Test Description";
            var isVisible = true;
            var minimal = false;
            var defaultValues = new Dictionary<int, string> { { 1, "Value1" }, { 2, "Value2" } };

            // Act
            var fields = new Fields(name, isEditable, isRequired, description, isVisible, minimal, defaultValues);

            // Assert
            Assert.AreEqual(name, fields.Name);
            Assert.AreEqual(isEditable, fields.IsEditable);
            Assert.AreEqual(isRequired, fields.IsRequired);
            Assert.AreEqual(description, fields.Description);
            Assert.AreEqual(isVisible, fields.IsVisible);
            Assert.AreEqual(minimal, fields.Minimal);
            Assert.AreEqual(defaultValues, fields.DefaultValues);
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenNameIsEmpty()
        {
            // Arrange
            var name = string.Empty;
            var isEditable = true;
            var isRequired = false;
            var description = "Test Description";
            var isVisible = true;
            var minimal = false;
            var defaultValues = new Dictionary<int, string> { { 1, "Value1" }, { 2, "Value2" } };

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new Fields(name, isEditable, isRequired, description, isVisible, minimal, defaultValues));
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenDescriptionIsEmpty()
        {
            // Arrange
            var name = "Test Name";
            var isEditable = true;
            var isRequired = false;
            var description = string.Empty;
            var isVisible = true;
            var minimal = false;
            var defaultValues = new Dictionary<int, string> { { 1, "Value1" }, { 2, "Value2" } };

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new Fields(name, isEditable, isRequired, description, isVisible, minimal, defaultValues));
        }

        [Test]
        public void Constructor_ShouldThrowException_WhenDefaultValuesIsEmpty()
        {
            // Arrange
            var name = "Test Name";
            var isEditable = true;
            var isRequired = false;
            var description = "Test Description";
            var isVisible = true;
            var minimal = false;
            var defaultValues = new Dictionary<int, string>();

            // Act & Assert
            Assert.Throws<DomainExceptionValidation>(() => new Fields(name, isEditable, isRequired, description, isVisible, minimal, defaultValues));
        }
    }
}
