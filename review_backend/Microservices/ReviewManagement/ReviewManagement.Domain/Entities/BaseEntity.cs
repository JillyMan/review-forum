using System;

namespace ReviewManagement.Domain.Entities
{
    public class BaseEntity
    {
        public int Id { get; set; }

        public DateTimeOffset CreatedAt { get; set; }
    }
}