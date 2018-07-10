using LiveKart.Entities;
using Repository.Pattern.Repositories;
using LiveKart.Repository;
using Service.Pattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveKart.Service
{

	public class UserService : Service<User>, IUserService
	{
		private readonly IRepository<User> _repository;

		public UserService(IRepository<User> repository)
			: base(repository)
		{
			_repository = repository;
		}

		public bool IsUserExist(string userEmail)
		{
			return _repository.IsUserExist(userEmail);
		}

		public User Login(string email, string password)
		{
			var user = _repository.Login(email, password);
			return user;
		}

		public User ChangePassword(string userName, string encriptedCurrentPass, string encriptedNewPass)
		{
			var user = _repository.Login(userName, encriptedCurrentPass);

			if (user != null)
			{
				user.Password = encriptedNewPass;
				_repository.Update(user);
			}
			return user;
		}

	}
}
