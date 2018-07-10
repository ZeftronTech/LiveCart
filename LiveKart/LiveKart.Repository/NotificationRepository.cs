using System.Linq;
using LiveKart.Entities;
using Repository.Pattern.Repositories;

namespace LiveKart.Repository
{
	public static class NotificationRepository
	{
		public static IQueryable<Notification> Notifications(
			this IRepository<Notification> repository)
		{
			return repository.Queryable();
		}

		public static IQueryable<Notification> GetByBeaconNumQuery(
			this IRepository<Notification> repository,
			string beaconNum)	
		{
			var schedulesQuery = repository.GetRepository<BeaconSchedule>().Queryable();
			var beaconsQuery = repository.GetRepository<Beacon>().Queryable();
			var notificationsQuery = repository.Queryable();

			IQueryable<Notification> resultQuery = notificationsQuery
				.Where(m => (from s in schedulesQuery
							 join beacon in beaconsQuery on s.BeaconID equals beacon.Id
							 where beacon.BeaconID == beaconNum
							 select s.NotificationID).Contains(m.NotificationID));
			return resultQuery;
		}
	}

}