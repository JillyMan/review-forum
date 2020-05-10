using ReviewManagement.App.Commands.Common;

namespace ReviewManagement.App.Commands.City.Update
{
    public class CommandUpdateCity : ICommandUpdateBase<Domain.Entities.City>
    {
        public int Id { get; set; }

        public int? CountryId { get; set; }

        public string Name { get; set; }
    }
}
