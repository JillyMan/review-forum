using System;

namespace ReviewManagement.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        public int PlaceId { get; set; }

        public Place Place { get; set; }

        public int UserId { get; set; }

        public UserInfo User { get; set; }

        public string Text { get; set; }

        public static Comment Create(string text, int userId, int placeId)
        {
            return new Comment()
            {
                Text = text,
                UserId = userId,
                PlaceId = placeId,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}