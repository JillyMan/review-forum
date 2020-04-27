using System;
using System.Collections.Generic;
using System.Linq;

namespace ReviewManagement.Domain.Entities
{
    public class Thing : BaseEntity
    {
        public string Name { get; set; }

        public string UrlIImage { get; set; }

        public IList<ThingRateInfo> Rates { get; set; }

        public float Rate
        {
            get
            {
                if (Rates?.Count() > 0)
                {
                    return Rates.Average(x => x.Rate);
                }

                return 0;
            }
        }

        public string Description { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public ICollection<Comment> Comments { get; set; }

        public static Thing Create(string urlImage, int categoryId, string description)
        {
            return new Thing()
            {
                UrlIImage = urlImage,
                CategoryId = categoryId,
                Description = description,
                CreatedAt = DateTime.UtcNow
            };
        }
    }
}