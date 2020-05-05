﻿namespace ReviewManagement.App.Commands.Place.AddPlace
{
    public class AddressDto
    {
        public int CountryId { get; set; }

        public int CityId { get; set; }

        public string Street { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }
    }
}
