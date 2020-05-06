using System.Collections.Generic;

namespace ReviewManagement.Domain.Entities
{
    public class Dish
    {
        public int Id { get; set; }

        public int PlaceId { get; set; }

        public Place Place { get; set; }

        public string Name { get; set; }

        public string ImageUrl { get; set; }

        public float Rate { get; set; }

        public ICollection<DishRate> Rates { get; set; }
    }
}