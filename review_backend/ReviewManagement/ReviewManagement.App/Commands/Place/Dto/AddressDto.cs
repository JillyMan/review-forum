namespace ReviewManagement.App.Commands.Place.Dto
{
    public class AddressDto
    {
        public int? Id { get; set; }

        public int CityId { get; set; }

        public string Street { get; set; }

        public float Latitude { get; set; }

        public float Longitude { get; set; }
    }
}
