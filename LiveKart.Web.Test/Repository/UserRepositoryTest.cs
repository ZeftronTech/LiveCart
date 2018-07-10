using LiveKart.Entities;
using LiveKart.Repository;
using LiveKart.Web.API;
using LiveKart.Web.Test.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace LiveKart.Web.Test.Repository
{
	[TestClass]
	public class UserRepositoryTest
	{
		[TestMethod]
		public void IsUserExist_UserTestName_ReturnsTrue()
		{
			using (IDataContext livekartFakeContext = new LiveKartFakeContext())
			using (IUnitOfWork unitOfWork = new UnitOfWork(livekartFakeContext))
			{
				//arrenge 
				unitOfWork.Repository<User>().Insert(new User { LoginID = 999, UserName = "TestUser", ObjectState = ObjectState.Added });
				unitOfWork.Repository<User>().Insert(new User { LoginID = 999, UserName = "UserTest", ObjectState = ObjectState.Added });
				unitOfWork.SaveChanges();
				string userName = "TestUser";

				//act
				var user = unitOfWork.Repository<User>().IsUserExist(userName);

				//assert
				Assert.IsTrue(user);
			}

		}

		[TestMethod]
		public void IsUserExist_UserEmpty_ReturnsFalse()
		{
			using (IDataContext livekartFakeContext = new LiveKartFakeContext())
			using (IUnitOfWork unitOfWork = new UnitOfWork(livekartFakeContext))
			{
				//arrenge 
				unitOfWork.Repository<User>().Insert(new User { LoginID = 999, UserName = "TestUser", ObjectState = ObjectState.Added });
				unitOfWork.Repository<User>().Insert(new User { LoginID = 999, UserName = "UserTest", ObjectState = ObjectState.Added });
				unitOfWork.SaveChanges();
				string userName = "";

				//act
				var user = unitOfWork.Repository<User>().IsUserExist(userName);

				//assert
				Assert.IsFalse(user);
			}
		}

		[TestMethod]
		public void Add_UserEmpty_ReturnsFalse()
		{
			using (IDataContext livekartFakeContext = new LiveKartEntities())
			using (IUnitOfWork unitOfWork = new UnitOfWork(livekartFakeContext))
			{

				var company = new Company() { CompanyName = "test" };
				var userNew = new User() { UserName = "admin@droisys.com", Email = "olga@mobiglue.com", Company = company ,ObjectState = ObjectState.Added };
				//arrenge 
				unitOfWork.Repository<User>().Insert(userNew);
				//unitOfWork.Repository<User>().Insert(new User { UserName = "admin@droisys.com", Email = "olga@mobiglue.com", ObjectState = ObjectState.Added });
				//unitOfWork.Repository<User>().Insert(new User { UserName = "admin@droisys.com", Email = "olga@mobiglue.com", ObjectState = ObjectState.Added });
				//unitOfWork.Repository<User>().Insert(new User { UserName = "admin@droisys.com", Email = "olga@mobiglue.com", ObjectState = ObjectState.Added });
				
				
				
				unitOfWork.SaveChanges();
				string userName = "admin@droisys.com";

				//act
				var user = unitOfWork.Repository<User>().IsUserExist(userName);

				//assert
				Assert.IsFalse(user);
			}

		}

		[TestMethod]
		public void FindUser_UserEmpty_ReturnsFalse()
		{
			using (IDataContext livekartFakeContext = new LiveKartEntities())
			using (IUnitOfWork unitOfWork = new UnitOfWork(livekartFakeContext))
			{

				//arrenge 
				var user = unitOfWork.Repository<User>().IsUserExist("jkgjhg");
				//assert
				Assert.IsFalse(user);
			}

		}

		[TestMethod]
		public void Login_NameAndPassword_ReturnsUser()
		{
			using (IDataContext livekartFakeContext = new LiveKartEntities())
			using (IUnitOfWork unitOfWork = new UnitOfWork(livekartFakeContext))
			{
				string name = "test";
				string password = "jhgjhg";

				//arrenge 
				var user = unitOfWork.Repository<User>().Login(name, password);

				//assert
				Assert.IsNotNull(user);
			}

		}


	}
}
