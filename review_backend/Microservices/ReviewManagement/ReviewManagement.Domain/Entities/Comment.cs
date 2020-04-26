using System;

namespace ReviewManagement.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public int ThingId { get; set; }

        public Thing Thing { get; set; }

        public string UserId { get; set; }

        public string Text { get; set; }

        public static Comment Create(string text, string userId, int thingId)
        {
            return new Comment()
            {
                Text = text,
                UserId = userId,
                ThingId = thingId,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}