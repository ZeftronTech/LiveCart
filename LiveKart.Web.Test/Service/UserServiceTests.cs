using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveKart.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Pattern.DataContext;
using Repository.Pattern.UnitOfWork;
using Repository.Pattern.Ef6;
using LiveKart.Entities;
namespace LiveKart.Service.Tests
{
	[TestClass()]
	public class UserServiceTests
	{
		[TestMethod()]
		public void UserServiceTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void IsUserExistTest()
		{
			Assert.Fail();
		}

		[TestMethod()]
		public void LoginTest()
		{
			Assert.Fail();
		}


		[TestMethod]
		public void ChangePassword_NameAndPasswordAndNewPassword_ReturnsUserWithNewPassword()
		{
			using (IDataContext livekartFakeContext = new LiveKartEntities())
			using (IUnitOfWork unitOfWork = new UnitOfWork(livekartFakeContext))
			{
				IUserService userService = new UserService(unitOfWork.Repository<User>());
				string name = "test";
				string password = "jhgjhgNew";

				string passwordNew = "password";
				//arrenge 
				var user = userService.ChangePassword(name, password ,passwordNew);
				unitOfWork.SaveChanges();

				user = userService.Find(user.LoginID);

				//assert
				Assert.AreSame(user.Password, passwordNew);
			}

		}


		[TestMethod]
		public void FindUser_NameAndPasswordAndNewPassword_ReturnsUserWithNewPassword()
		{
			using (IDataContext livekartFakeContext = new LiveKartEntities())
			using (IUnitOfWork unitOfWork = new UnitOfWork(livekartFakeContext))
			{
				IUserService userService = new UserService(unitOfWork.Repository<User>());
				string name = "company";

				//arrenge 
				//var user = userService.Find(name);
				var company = userService
					.Query(x => x.UserName == name)
					.Include(x => x.Company)					
					.Select()
					.SingleOrDefault();
	
				//assert
				Assert.IsNotNull(company.Company);
			}

		}
	}
}
