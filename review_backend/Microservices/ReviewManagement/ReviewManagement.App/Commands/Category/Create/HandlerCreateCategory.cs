using AutoMapper;
using ReviewManagement.App.Infrastructure;

namespace ReviewManagement.App.Commands.Category.Add
{
    public class HandlerCreateCategory : Common.HandlerCreateBase<CommandCreateaCategory, Domain.Entities.Category>
    {
        public HandlerCreateCategory(IReviewManagementContext ctx, IMapper mapper) :
            base(ctx, mapper)
        {
        }

        protected override Domain.Entities.Category PrepareEntity(CommandCreateaCategory command)
        {
            var entity = Mapper.Map<Domain.Entities.Category>(command);
            return entity;
        }
    }
}
