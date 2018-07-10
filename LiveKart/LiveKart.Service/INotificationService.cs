using System.Collections.Generic;
using LiveKart.Entities;
using Service.Pattern;

namespace LiveKart.Service
{
	public interface INotificationService : IService<Notification>
	{
		IEnumerable<Notification> GetByBeaconNum(string beaconNum);
	}
}
