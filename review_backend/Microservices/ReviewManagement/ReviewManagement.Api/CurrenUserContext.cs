using Microsoft.AspNetCore.Http;
using ReviewManagement.App.Exceptions;
using ReviewManagement.App.Infrastructure;
using ReviewManagement.Domain.Entities;
using ReviewManagement.Domain.Enums;
using System.Linq;
using System.Security.Claims;

namespace ReviewManagement.Api
{
	public class CurrenUserContext : ICurrentUserContext
	{
		public UserInfo CurrentUser { get; }

		public CurrenUserContext(IReviewManagementContext reviewContext, IHttpContextAccessor httpContextAccessor)
		{
			var userId = GetUserId(httpContextAccessor.HttpContext.User);
			CurrentUser = reviewContext.Users.FirstOrDefault(x => x.Id == userId);

			if (CurrentUser == null)
			{
				throw new UserNotFoundException();
			}
		}

		public Role Role()
		{
			return CurrentUser.Role;
		}

		private const string IdClaimType = "http://schemas.microsoft.com/identity/claims/objectidentifier";

		private static int GetUserId(ClaimsPrincipal claimsPrincipal)
		{
			var claim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == IdClaimType);

			if (claim == null || !int.TryParse(claim.Value, out var id))
			{
				throw new UserNotFoundException($"Unable to find claim of type '{IdClaimType}'.");
			}

			return id;
		}
	}
}
