#region

using System.Collections.Generic;
using System.Linq;
using LiveKart.Entities;
using Repository.Pattern.Repositories;

#endregion

namespace LiveKart.Repository
{
	public static class NotificationMessagesRepository
	{
		public static IQueryable<NotificationMessage> NotificationMessages(
			this IRepository<NotificationMessage> repository)
		{
			return repository.Queryable();
		}

		public static long Add(this IRepository<NotificationMessage> repository, NotificationMessage message)
		{
			repository.Insert(message);
			return message.NotificationMessageId;
		}

		public static void Update(this IRepository<NotificationMessage> repository, NotificationMessage message)
		{
			repository.Update(message);
			return;
		}
	}
}