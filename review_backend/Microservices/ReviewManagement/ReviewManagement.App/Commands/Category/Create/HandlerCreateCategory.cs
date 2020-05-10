using AutoMapper;
using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Category.Create
{
    public class HandlerCreateCategory : HandlerCreateBase<CommandCreateCategory, Domain.Entities.Category>
    {
        public HandlerCreateCategory(IReviewManagementContext ctx, IMapper mapper) :
            base(ctx, mapper)
        {
        }

        protected override Domain.Entities.Category PrepareEntity(CommandCreateCategory command)
        {
            var entity = Mapper.Map<Domain.Entities.Category>(command);
            return entity;
        }
    }
}
