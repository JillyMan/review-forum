using System;

namespace ReviewManagement.App.Models.Place
{
	public class CommentModel
	{
		public int Id { get; set; }

		public string Text { get; set; }

		public DateTime CreatedAt { get; set; }

		public UserInfoModel CreatedBy { get; set; }
	}
}
