using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OldBarom.Core.DLC.Domain.Entities.Ativos
{
    public class Cities : Entity
    {
        public string Name { get; private set; }
        public bool IsEnable { get; private set; }
        public float Latitude { get; private set; }
        public float Longitude { get; private set; }

        public Cities(string name, float latitude, float longitude)
        {
            ValidateDomain(name, latitude, longitude);
        }

        public Cities(Guid id, string name, float latitude, float longitude)
        {
            ValidateDomain(name, latitude, longitude);
            Id = id;
        }

        private void ValidateDomain(string name, float latitude, float longitude)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Name too short");
            DomainExceptionValidation.When(name.Length > 100, "Name too long");
            DomainExceptionValidation.When(latitude < -90, "Latitude is required");
            DomainExceptionValidation.When(latitude > 90, "Latitude is required");
            DomainExceptionValidation.When(longitude < -180, "Longitude is required");
            DomainExceptionValidation.When(longitude > 180, "Longitude is required");

            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }
    }
}
