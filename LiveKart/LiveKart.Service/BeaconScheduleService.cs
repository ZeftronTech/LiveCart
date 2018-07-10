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
	public class BeaconScheduleService : Service<BeaconSchedule>, IBeaconScheduleService
	{
		private readonly IRepository<BeaconSchedule> _repository;
		private readonly IRepository<Beacon> _beaconRepository;

		public BeaconScheduleService(IRepository<BeaconSchedule> repository, IRepository<Beacon> beaconRepository)
			: base(repository)
		{
			_repository = repository;
			_beaconRepository = beaconRepository;
		}

		public IEnumerable<BeaconSchedule> GetByBeaconNum(string beaconId)
		{
			var beacon = _beaconRepository.GetByBeaconNum(beaconId);
			return _repository.Schedules().Where(x => x.BeaconID == beacon.Id).ToList();
		}
	}
}
