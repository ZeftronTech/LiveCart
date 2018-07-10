using System;
using System.Collections.Generic;
using LiveKart.Entities;
using Service.Pattern;

namespace LiveKart.Service
{
	public interface IBeaconScheduleService : IService<BeaconSchedule>
	{
		IEnumerable<BeaconSchedule> GetByBeaconNum(string beaconId);
	}
}
