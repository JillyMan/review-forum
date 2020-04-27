using System;

namespace ReviewManagement.Domain.Entities
{
    public class ThingRateInfo : BaseEntity
    {
        public int ThingId { get; set; }

        public Thing Thing { get; set; }

        public string UserId { get; set; }

        public float Rate { get; set; }

        public static ThingRateInfo Create(int thingId, string userId, float rate)
        {
            return new ThingRateInfo()
            {
                ThingId = thingId,
                CreatedAt = DateTime.UtcNow,
                UserId = userId,
                Rate = rate
            };
        }
    }
}