#region

using System.Collections.Generic;
using System.Linq;
using LiveKart.Entities;
using Repository.Pattern.Repositories;

#endregion

namespace LiveKart.Repository
{
	public static class StandardMessageRepository
	{
		public static IQueryable<StandardMessage> StandardMessages(
			this IRepository<StandardMessage> repository)
		{
			return repository.Queryable();
		}

		public static long Add(this IRepository<StandardMessage> repository, StandardMessage message)
		{
			repository.Insert(message);
			return message.StandardMessageId;
		}
	}
}