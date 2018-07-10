using LiveKart.Entities;
using Repository.Pattern.Repositories;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveKart.Service
{
	public interface ICompanySevice : IService<Company>
	{
        Country FindCountry(long countryID);
    }

	public class CompanySevice : Service<Company>, ICompanySevice
	{
        private readonly IRepository<Company> _repository;

		public CompanySevice(IRepository<Company> repository)
			: base(repository)
		{
            _repository = repository;

		}

        public Country FindCountry(long countryId)
        {
            return _repository.GetRepository<Country>().Find(countryId);
        }
    }

}
