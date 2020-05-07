using ReviewManagement.Domain.Entities;
using ReviewManagement.Domain.Enums;

namespace ReviewManagement.App.Infrastructure
{
	public interface ICurrentUserContext
	{
		UserInfo CurrentUser { get; }

		Role Role();
	}
}
