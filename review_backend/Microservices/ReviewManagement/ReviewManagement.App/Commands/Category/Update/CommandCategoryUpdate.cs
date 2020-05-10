using ReviewManagement.App.Commands.Common;

namespace ReviewManagement.App.Commands.Category.Update
{
    public class CommandCategoryUpdate : ICommandUpdateBase<Domain.Entities.Category>
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
