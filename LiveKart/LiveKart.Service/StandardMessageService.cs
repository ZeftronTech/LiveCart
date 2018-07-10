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
	public class StandardMessageService : Service<StandardMessage>, IStandardMessageService
	{
		private readonly IRepository<StandardMessage> _repository;

		public StandardMessageService(IRepository<StandardMessage> repository)
			: base(repository)
		{
			_repository = repository;
		}

		public IQueryable<StandardMessage> StandardMessages()
		{
			return _repository.StandardMessages();
		}

	}
}
