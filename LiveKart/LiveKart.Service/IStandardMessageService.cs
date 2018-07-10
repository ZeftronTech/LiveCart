using System;
using System.Collections.Generic;
using LiveKart.Entities;
using System.Linq;
using Service.Pattern;

namespace LiveKart.Service
{
	public interface IStandardMessageService : IService<StandardMessage>
	{
		IQueryable<StandardMessage> StandardMessages();
		//IEnumerable<StandardMessage> GetByNotificationMessageId(long id);
		void Update(StandardMessage message);
		StandardMessage Find(params object[] keyValues);
	}
}
