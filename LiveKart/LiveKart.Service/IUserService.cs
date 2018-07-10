using System;
using LiveKart.Entities;
using Service.Pattern;

namespace LiveKart.Service
{
	
	public interface IUserService : IService<User>
	{
		bool IsUserExist(string userEmail);
		User Login(string email, string password);
		User ChangePassword(string userName, string encriptedCurrentPass, string encriptedNewPass);
	}
}
