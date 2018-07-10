#region

using System.Collections.Generic;
using System.Linq;
using LiveKart.Entities;
using Repository.Pattern.Repositories;

#endregion

namespace LiveKart.Repository
{
	// Exmaple: How to add custom methods to a repository.
	public static class BeaconRepository
	{
		public static Beacon GetByBeaconNum(
			this IRepository<Beacon> repository,
			string beaconNum)
		{
			return repository
				.Queryable()
				.Where(x => x.BeaconID == beaconNum)
				.SingleOrDefault();
		}
	}
}