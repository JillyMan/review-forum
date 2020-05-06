using System;
using System.Collections.Generic;

namespace ReviewManagement.Domain.Entities
{
    public class Place : AuditableEntity
    {
        public string Name { get; set; }

        public float Rate { get; set; }

        public string ImageUrl { get; set; }

        public string PhoneNumber { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }
     
        public ICollection<HeaderImage> HeaderImages { get; set; }

        public ICollection<Dish> Dishes { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public static Place Create(string urlImage, 
            int categoryId, 
            string phoneNumber,
            Address address, 
            ICollection<Dish> dishes,
            ICollection<HeaderImage> headerImages)
        {
            return new Place()
            {
                ImageUrl = urlImage,
                Dishes = dishes,
                Address = address,
                PhoneNumber = phoneNumber,
                CategoryId = categoryId,
                HeaderImages = headerImages,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}