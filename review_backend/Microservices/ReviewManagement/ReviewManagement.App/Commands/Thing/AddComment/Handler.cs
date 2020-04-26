using MediatR;
using Review.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace ReviewManagement.App.Commands.Thing.AddComment
{
    public class Handler : IRequestHandler<Command, Comment>
    {
        private IReviewManagementContext _context;

        public Handler(IReviewManagementContext context)
        {
            _context = context;
        }

        public async Task<Comment> Handle(Command request, CancellationToken cancellationToken)
        {
            var comment = Comment.Create(request.Text, request.UserId, request.ThingId);
            var commentEntity = await _context.Comments.AddAsync(comment);
            await _context.SaveChangesAsync();
            return commentEntity.Entity;
        }
    }
}
