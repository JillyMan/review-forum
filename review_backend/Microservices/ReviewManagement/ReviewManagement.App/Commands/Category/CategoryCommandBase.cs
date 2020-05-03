using MediatR;

namespace ReviewManagement.App.Commands.Category
{
	public class CategoryCommandBase<TResult> : IRequest<TResult>
	{
		public string Name { get; set; }
	}
}
