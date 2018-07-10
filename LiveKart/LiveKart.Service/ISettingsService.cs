using LiveKart.Entities;
using Service.Pattern;

namespace LiveKart.Service
{
	public interface ISettingsService : IService<Settings>
	{
		Settings ByCompany(long companyId);
		void Insert(Settings settings);
		void Update(Settings settings);
	}
}
