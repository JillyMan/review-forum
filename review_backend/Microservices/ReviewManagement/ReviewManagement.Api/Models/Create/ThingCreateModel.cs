namespace ReviewManagement.Api.Models.Create
{
    public class ThingCreateModel
    {
        public string Name { get; set; }

        public string UrlImage { get; set; }

        public int CategoryId { get; set; }

        public string Description { get; set; }
    }
}
