using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ReviewForum.Contract;
using ReviewForum.Core.DataAccess.Interfaces;
using ReviewForum.Core.Services.Interfaces;

namespace ReviewForum.Core.Services
{
    public class ThingReviewService : IThingReviewService
    {
        IRepository<ThingItem> _repository;

        public ThingReviewService(IRepository<ThingItem> repository)
        {
            _repository = repository;
        }

        public Task Add(ThingItem item)
        {
            throw new System.NotImplementedException();
        }

        public Task<List<ThingItem>> GetAll()
        {
            return _repository.GetAll();
        }

        public Task<ThingItem> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task Update(ThingItem item)
        {
            throw new NotImplementedException();
        }
    }
}