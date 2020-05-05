using System;
using System.Collections.Generic;

namespace ReviewManagement.Domain.Entities
{
    public class Place : AuditableEntity
    {
        public string Name { get; set; }

        public string UrlImage { get; set; }

        public float Rate { get; set; }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }

        public ICollection<HeaderImage> HeaderImages { get; set; }

        public ICollection<Dish> Dishes { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public static Place Create(string urlImage, int categoryId, string description, 
            Address address, 
            ICollection<Dish> dishes,
            ICollection<HeaderImage> headerImages)
        {
            return new Place()
            {
                UrlImage = urlImage,
                Dishes = dishes,
                Address = address,

                CategoryId = categoryId,
                Description = description,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}