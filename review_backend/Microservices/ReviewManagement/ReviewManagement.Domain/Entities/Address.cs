﻿namespace ReviewManagement.Domain.Entities
{
    public class Address : BaseEntity
    {
        public int CityId { get; set; }

        public City City { get; set; }

        public int CountryId { get; set; }

        public Country Country { get; set; }

        public string Street { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }
    }
}