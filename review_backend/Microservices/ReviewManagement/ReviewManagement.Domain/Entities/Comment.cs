using System;

namespace ReviewManagement.Domain.Entities
{
    public class Comment : AuditableEntity
    {
        public int PlaceId { get; set; }

        public Place Place { get; set; }

        public string Text { get; set; }
    }
}