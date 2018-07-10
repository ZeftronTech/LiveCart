using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using LiveKart.Web.API;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LiveKart.Web.API.Tests
{
	[TestClass()]
	public class NotificationControllerTests
	{
		//[TestMethod()]
		//public void All_PathNull_ReturnsEmptyList()
		//{

		//	var contestId = Guid.NewGuid();
		//	INotificationDB notification = new NotificationDB();

		//	var controller = new NotificationController(notification);

		//	var result = controller.All();

		//	Assert.IsNotNull(result);
		//}

		//[TestMethod()]
		//public void All_Path3_ReturnsList()
		//{

		//	INotificationDB notification = new NotificationDB();
		//	var controller = new NotificationController(notification);

		//	var result = controller.All(3);
		//	Assert.IsNotNull(result);
		//}

		//[TestMethod()]
		//public void Get_Pass10_ReturnsEntity()
		//{
		//	INotificationDB notification = new NotificationDB();
		//	var controller = new NotificationController(notification);

		//	var result = controller.Get(10);
		//	Assert.IsNotNull(result);
		//}

		//[TestMethod()]
		//public void ByBeacon_PassBeaconIdANDlastRequestTime_ReturnsNotfications()
		//{
		//	INotificationDB notification = new NotificationDB();
		//	var controller = new NotificationController(notification);
		//	string beaconId = "" ;

		//	var result = controller.ByBeaconId(beaconId);
		//	Assert.IsNotNull(result);
		//}

		[TestMethod()]
		public void DeleteTest()
		{
		}

		[TestMethod()]
		public void Post_SendNotification_NotificationCreated()
		{

		}

		[TestMethod()]
		public void PutTest()
		{
		}

		[TestMethod()]
		public void PublishTest()
		{
		}
	}
}
