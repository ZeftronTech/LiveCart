using LiveKart.Entities;
using Service.Pattern;

namespace LiveKart.Service
{
	public interface IBeaconService : IService<Beacon> 
	{
		Beacon GetByBeaconNum(string beaconId);
	}
}
