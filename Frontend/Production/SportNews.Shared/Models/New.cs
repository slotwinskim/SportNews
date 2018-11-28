using System;

namespace SportNews.Shared.Models
{
	public class New : Entity
	{
		public string Title { get; set; }
		public int Points { get; set; }
		public Uri Domain { get; set; }
		public DateTime CreatedAt { get; set; }
		public DateTime LastEditedAt { get; set; }
		public User Author { get; set; }
	}
}