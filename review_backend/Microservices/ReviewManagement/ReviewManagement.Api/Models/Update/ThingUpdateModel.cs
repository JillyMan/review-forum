namespace ReviewManagement.Api.Models.Update
{
    public class ThingUpdateModel
    {
        public int ThingId { get; set; }
        
        public string Name { get; set; }

        public string UrlImage { get; set; }

        public int? CategoryId { get; set; }

        public string Description { get; set; }
    }
}
