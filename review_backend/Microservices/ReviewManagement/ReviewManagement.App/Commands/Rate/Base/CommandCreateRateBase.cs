using MediatR;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Rate.Base
{
    public abstract class CommandCreateRateBase<TResponse> : IRequest<TResponse>
        where TResponse : RatableEntity
    {
        public int UserId { get; set; }

        public float Rate { get; set; }
    }
}
