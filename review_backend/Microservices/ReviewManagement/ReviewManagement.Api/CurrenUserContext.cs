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
		private UserInfo _currentUser;

		public UserInfo CurrentUser 
		{
			get
			{
				if (_currentUser == null || !_currentUser.IsActive)
				{
					throw new UserNotFoundException();
				}

				return _currentUser;
			}
		}

		public CurrenUserContext(IReviewManagementContext reviewContext, IHttpContextAccessor httpContextAccessor)
		{
			var userId = GetUserId(httpContextAccessor.HttpContext.User);
			_currentUser = reviewContext.Users.FirstOrDefault(x => x.Id == userId);
		}

		public Role Role()
		{
			return CurrentUser.Role;
		}

		private static int GetUserId(ClaimsPrincipal claimsPrincipal)
		{
			var claim = claimsPrincipal.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);

			if (claim == null || !int.TryParse(claim.Value, out var id))
			{
				return -1;
//				throw new UserNotFoundException($"Unable to find claim of type '{ClaimTypes.NameIdentifier}'.");
			}

			return id;
		}
	}
}
