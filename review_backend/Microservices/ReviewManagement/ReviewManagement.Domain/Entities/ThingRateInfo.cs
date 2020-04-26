namespace ReviewManagement.Domain.Entities
{
    public class ThingRateInfo : BaseEntity
    {
        public int ThingId { get; set; }

        public Thing Thing { get; set; }

        public string UserId { get; set; }

        public float Rate { get; set; }
    }
}