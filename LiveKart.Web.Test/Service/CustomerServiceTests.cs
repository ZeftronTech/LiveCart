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
	public class CustomerServiceTests
	{
		[TestMethod()]
		public void GetByBeaconNumTest()
		{
			//using (IDataContextAsync context = new KlivekartdpdContext())
			//using (IUnitOfWork unitOfWork = new UnitOfWork(context))
			//using (IBeaconService customerService = new BeaconService(unitOfWork))
			//{
			//	//var newCustomer = new Customer
			//	//{
			//	//	Address = "2100 Ross Ave",
			//	//	City = "Dallas",
			//	//	CompanyName = "CBRE",
			//	//	ContactTitle = "Software Engineer",
			//	//	Country = "US",
			//	//	CustomerID = "CBRE",
			//	//	Fax = "2222222222",
			//	//	Phone = "1111111111",
			//	//	PostalCode = "75042",
			//	//	Region = "Dallas"
			//	//};

			//	customerService.Add(newCustomer);

			//	unitOfWork.SaveChanges();

			//	var savedCustomer = customerService.GetCustomer("CBRE");

			//	Assert.AreEqual(newCustomer.CustomerID, savedCustomer.CustomerID);

		}
	}
}
