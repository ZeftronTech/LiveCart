using System.Collections.Generic;
using System.Linq;
using Service.Pattern;
using LiveKart.Entities;
using Repository.Pattern.Repositories;

namespace LiveKart.Service
{
	public class NotificationService : Service<Notification>, INotificationService
	{
		private readonly IRepository<Notification> _notificationRepo;

		public NotificationService(IRepository<Notification> repository)
			: base(repository)
		{
			_notificationRepo = repository;
		}

		public IEnumerable<Notification> GetByBeaconNum(string beaconNum)
		{
			var notifications = _notificationRepo.Query()
			                                     .Include(n => n.BeaconSchedules.Select(bs => bs.Beacon))
			                                     .Select()
												 .Where( n =>
												 	n.BeaconSchedules.FirstOrDefault(bs => bs.Beacon.BeaconID == beaconNum) != null &&
													n.Active == true)
			                                     .AsEnumerable();
			return notifications;
		}
	}
}
