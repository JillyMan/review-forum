using ReviewManagement.App.Commands.Common;
using ReviewManagement.App.Commands.Country.Dto;
using System.Collections.Generic;

namespace ReviewManagement.App.Commands.Country.Update
{
    public class CommandCountryUpdate : ICommandUpdateBase<Domain.Entities.Country>
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public ICollection<CityDto> Cities { get; set; }

    }
}
