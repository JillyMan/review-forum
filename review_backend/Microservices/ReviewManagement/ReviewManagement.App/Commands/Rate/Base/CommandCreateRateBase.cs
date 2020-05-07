using MediatR;
using ReviewManagement.App.Models;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Rate.Base
{
    public abstract class CommandCreateRateBase<TResponse> : IRequest<TResponse>, ICreateCommand
        where TResponse : RatableEntity
    {
        public int Rate { get; set; }

        public UserInfo CreatedBy { get; set; }
    }
}
