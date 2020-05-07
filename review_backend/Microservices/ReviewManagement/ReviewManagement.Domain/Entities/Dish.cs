using System.Collections.Generic;

namespace ReviewManagement.Domain.Entities
{
    public class Dish : AuditableEntity
    {
        public int PlaceId { get; set; }

        public Place Place { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public int Rate { get; set; }

        public float Price { get; set; }

        public ICollection<DishRate> Rates { get; set; }
    }
}