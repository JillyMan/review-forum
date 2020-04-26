using System;

namespace ReviewManagement.Domain.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public static Category Create(string name)
        {
            return new Category()
            {
                Name = name,
                CreatedAt = DateTimeOffset.UtcNow
            };
        }
    }
}
