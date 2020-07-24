using System.Collections.Generic;

namespace ReviewManagement.Domain.Entities
{
    public class Dish : BaseEntity
    {
        public int PlaceId { get; set; }

        public Place Place { get; set; }

        public string Name { get; set; }

        public int? ImageId { get; set; }

        public Image Image { get; set; }

        public float Rate { get; set; }

        public float Price { get; set; }

        public ICollection<DishRate> Rates { get; set; }
    }
}