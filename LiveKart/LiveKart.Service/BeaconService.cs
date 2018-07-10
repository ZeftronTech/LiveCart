using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Pattern;
using LiveKart.Entities;
using Repository.Pattern.Repositories;
using LiveKart.Repository;

namespace LiveKart.Service
{
	public class BeaconService : Service<Beacon>, IBeaconService
	{
		private readonly IRepository<Beacon> _repository;

		public BeaconService(IRepository<Beacon> repository)
			: base(repository)
		{
			_repository = repository;
		}

		public Beacon GetByBeaconNum(string beaconId)
		{
			return _repository.GetByBeaconNum(beaconId);
		}
	}
}
