using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReviewForum.Contract;

namespace ReviewForum.Core.Services.Interfaces
{
    public interface IThingReviewService
    {
        Task Add(ThingItem item);

        Task Update(ThingItem item);

        Task<ThingItem> GetById(Guid id);

        Task<List<ThingItem>> GetAll();
    }
}
