using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.App.Models.Place;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Queries.GetPlace
{
    public class Handler : IRequestHandler<Query, PlaceModel>
    {
        private IMapper _mapper;
        private IReviewManagementContext _context;

        public Handler(IReviewManagementContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<PlaceModel> Handle(Query request, CancellationToken cancellationToken)
        {
            var place = await _context.Places
                .AsNoTracking()
                .Include(x => x.Category)
                .Include(x => x.Comments).ThenInclude(x => x.CreatedBy)
                .Include(x => x.HeaderImages).ThenInclude(x => x.Image)
                .Include(x => x.Address)
                .Include(x => x.Image)
                .Include(x => x.Dishes).ThenInclude(x => x.Image)
                .FirstOrDefaultAsync(x => x.Id == request.PlaceId) ?? throw new EntityNotFoundException();

            //todo: change it to SQL Triggers
            var rates = await _context.PlaceRateInfos
               .Where(x => x.PlaceId == place.Id)
               .ToListAsync();

            if (rates.Count > 0)
            {
                place.Rate = (float) rates.Average(x => x.Rate);
            }


            return _mapper.Map<PlaceModel>(place);
        }
    }
}
