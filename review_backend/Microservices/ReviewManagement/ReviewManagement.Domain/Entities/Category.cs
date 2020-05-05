using System;

namespace ReviewManagement.Domain.Entities
{
    public class Category : AuditableEntity
    {
        public string Name { get; set; }

        public static Category Create(string name)
        {
            return new Category()
            {
                Name = name,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}
