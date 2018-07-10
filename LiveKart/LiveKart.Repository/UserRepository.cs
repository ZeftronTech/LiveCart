using LiveKart.Entities;
using Repository.Pattern.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveKart.Repository
{
	public static class UserRepository
	{

		public static bool IsUserExist(
			this IRepository<User> repository,
			string userMail)
		{
			var test = repository
				.Queryable()
				.Any(x => x.UserName == userMail);

			return test;
		}

		public static User Login(
			this IRepository<User> repository,
			string userName, string encriptedPass)
		{
			var user = repository
				.Queryable()
				.Where(x => (x.UserName == userName && x.Password == encriptedPass))
				.FirstOrDefault();

			return user;
		}

	}
}
