using System;

namespace OldBarom.Core.DLC.Domain.Entities.Ativos
{
    public class Cities : Entity
    {
        // Propriedades da classe Cities
        public string Name { get; private set; }
        public bool IsEnable { get; private set; }
        public float Latitude { get; private set; }
        public float Longitude { get; private set; }

        // Construtor para criar uma nova instância de Cities
        public Cities(string name, float latitude, float longitude)
        {
            ValidateAndSetProperties(name, latitude, longitude);
        }

        // Construtor para criar uma instância de Cities com um ID específico
        public Cities(Guid id, string name, float latitude, float longitude)
        {
            ValidateAndSetProperties(name, latitude, longitude);
            Id = id;
        }

        // Método privado para validar e definir as propriedades
        private void ValidateAndSetProperties(string name, float latitude, float longitude)
        {
            // Validação do nome
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3 || name.Length > 100, "Name must be between 3 and 100 characters");

            // Validação da latitude
            DomainExceptionValidation.When(latitude < -90 || latitude > 90, "Latitude must be between -90 and 90");

            // Validação da longitude
            DomainExceptionValidation.When(longitude < -180 || longitude > 180, "Longitude must be between -180 and 180");

            // Definição das propriedades
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
