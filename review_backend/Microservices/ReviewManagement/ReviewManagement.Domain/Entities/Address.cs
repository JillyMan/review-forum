using System.Collections.Generic;

namespace ReviewManagement.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int CityId { get; set; }

        public City City { get; set; }

        public string Street { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }

        public ICollection<Place> Places { get; set; }
    }
}