#region

using System.Collections.Generic;
using System.Linq;
using LiveKart.Entities;
using Repository.Pattern.Repositories;

#endregion

namespace LiveKart.Repository
{
	public static class BeaconScheduleRepository
	{
		public static IQueryable<BeaconSchedule> Schedules(
			this IRepository<BeaconSchedule> repository)
		{
			return repository.Queryable();
		}
	}
}