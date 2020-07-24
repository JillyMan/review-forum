using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Infrastructure;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ReviewManagement.App.Commands.Place.Dto;
using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Commands.Place.Update
{
    public class HandlerUpdatePlace : IRequestHandler<CommandUpdatePlace, Domain.Entities.Place>
    {
        private readonly IMapper _mapper;
        private readonly IReviewManagementContext _context;

        public HandlerUpdatePlace(IReviewManagementContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<Domain.Entities.Place> Handle(CommandUpdatePlace request, CancellationToken cancellationToken)
        {
            var mappedEntity = _mapper.Map<Domain.Entities.Place>(request);
            var originalPlace = _context.Places
                                    .Include(x => x.Dishes).ThenInclude(x => x.Image)
                                    .Include(x => x.HeaderImages).ThenInclude(x => x.Image)
                                    .FirstOrDefault(x => x.Id == request.Id) ?? throw new EntityNotFoundException();

            //ProcessDishes(request, originalPlace);
            //ProcessHeaderImages(request, originalPlace);

            originalPlace.CategoryId =
                mappedEntity.CategoryId != 0 ? mappedEntity.CategoryId : originalPlace.CategoryId;
            originalPlace.Name = mappedEntity.Name ?? originalPlace.Name;
            originalPlace.PhoneNumber = mappedEntity.PhoneNumber ?? originalPlace.PhoneNumber;

            var updatedEntry = _context.Places.Update(originalPlace);

            await _context.SaveChangesAsync(cancellationToken);
            return updatedEntry.Entity;
        }

        private void ProcessDishes(CommandUpdatePlace request, Domain.Entities.Place originalPlace)
        {
            Dish updateDish(Dish oldDish, DishDto newDish)
            {
                oldDish.Name = newDish.Name ?? oldDish.Name;
                oldDish.Price = newDish.Price ?? oldDish.Price;
                oldDish.Image = newDish.Image != null ? _mapper.Map<Image>(newDish.Image) : oldDish.Image;

                return oldDish;
            }

            if (request.RemoveDishes?.Length > 0)
            {
                _context.Dishes.RemoveRange(
                    originalPlace.Dishes.Where(x => request.RemoveDishes.Contains(x.Id))
                );
            }

            if (!(request.Dishes?.Count > 0)) return;

            //var shouldBeUpdated = request.Dishes.Where(x => x.Id.HasValue && x.Id.Value > 0).Select(x => updateDish(x, ));

            //_context.Dishes.UpdateRange(
            //    _mapper.Map<IEnumerable<Domain.Entities.Dish>>(
            //        )
            //);

            var newDishes = request.Dishes.Where(x => x.Id != null && x.Id.Value == 0);
            if (newDishes.Any())
            {
                _context.Dishes.AddRange(_mapper.Map<IEnumerable<Domain.Entities.Dish>>(newDishes));
            }
        }

        private void ProcessHeaderImages(CommandUpdatePlace request, Domain.Entities.Place originalPlace)
        {
            if (request.RemoveHeaderImages?.Length > 0)
            {
                _context.HeaderPlaceImages.RemoveRange(
                    originalPlace.HeaderImages.Where(x => request.RemoveHeaderImages.Contains(x.Id))
                );
            }

            if (!(request.HeaderImages?.Count > 0)) return;

            _context.HeaderPlaceImages.UpdateRange(
                _mapper.Map<IEnumerable<Domain.Entities.HeaderPlaceImage>>(
                    request.HeaderImages.Where(x => x.Id.HasValue && x.Id.Value > 0)));

            var newImages = request.HeaderImages.Where(x => x.Id != null && x.Id.Value == 0);

            _context.HeaderPlaceImages.AddRange(
                _mapper.Map<IEnumerable<Domain.Entities.HeaderPlaceImage>>(newImages));
        }
    }
}
