﻿using System.Collections.Generic;

namespace ReviewManagement.Domain.Entities
{
    public class Place : AuditableEntity
    {
        public string Name { get; set; }

        public float Rate { get; set; }

        public int? ImageId { get; set; }

        public Image Image { get; set; }

        public string PhoneNumber { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public int AddressId { get; set; }

        public Address Address { get; set; }

        public ICollection<HeaderPlaceImage> HeaderImages { get; set; }

        public ICollection<Dish> Dishes { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public ICollection<PlaceRate> Rates { get; set; }
    }
}