using ReviewManagement.Domain.Entities;

namespace ReviewManagement.App.Models
{
	public interface ICreateCommand
	{
		public UserInfo CreatedBy { get; set; }
	}
}
