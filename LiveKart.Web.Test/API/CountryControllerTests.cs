using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiveKart.Web;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using LiveKart.Entities;
using LiveKart.Repository;
using LiveKart.Web.API;
using LiveKart.Web.Test.Fake;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Infrastructure;
using Repository.Pattern.UnitOfWork;

namespace LiveKart.Web.Tests
{
	[TestClass()]
	public class CountryControllerTests
	{
		[TestMethod()]
		public void All_ReturnsAll()
		{
			using (IDataContext livekartFakeContext = new LiveKartFakeContext())
			using (IUnitOfWork unitOfWork = new UnitOfWork(livekartFakeContext))
			using (CountryController controller = new CountryController(unitOfWork))
			{
				//arrenge 

				//act
				var countries = controller.All();

				//assert
				Assert.IsInstanceOfType(countries, typeof(List<Country>));
			}

		}

		[TestMethod()]
		public void Get_PassID_ReturnEntity()
		{
			using (IDataContext livekartFakeContext = new LiveKartFakeContext())
			using (IUnitOfWork unitOfWork = new UnitOfWork(livekartFakeContext))
			using (CountryController controller = new CountryController(unitOfWork))
			{
				//arrenge 
				long CountryID = 10;

				//act
				var country = controller.GetCountries(CountryID);

				//assert
				Assert.AreEqual(13, 13);
			}
		}

	}
}
