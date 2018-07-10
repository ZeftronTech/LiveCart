using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveKart.Entities;
using Repository.Pattern.Repositories;
using Service.Pattern;

namespace LiveKart.Service
{
	public class SettingsService : Service<Settings>, ISettingsService
	{
		private readonly IRepository<Settings> _repository;
		public SettingsService(IRepository<Settings> repository) : base(repository)
		{
			_repository = repository;
		}

		public Settings ByCompany(long companyId)
		{
			var settings =  _repository.Queryable().FirstOrDefault(s => s.CompanyId == companyId) ?? 
				new Settings
				{
					CompanyId = companyId,
					CloseMinRSSI = 0,
					CloseMaxRSSI = 70,
					NearMinRSSI = 80,
					NearMaxRSSI = 170,
					FarMinRSSI = 1000,
					FarMaxRSSI = 1100
				};
			return settings;
		}
	}
}