using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LiveKart.Shared.Entities
{
	public class Notification
	{
		#region Properties

		public long CampaignId { get; set; }
		public long NotificationId { get; set; }
		public long NotificationAlertId { get; set; }

		[Display(Name = "Campaign Name")]
		public string NotificationTitle { get; set; }

		[Display(Name = "Description")]
		public string Description { get; set; }

		public string NotificationImage { get; set; }
		public bool Active { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public long CompanyId { get; set; }
		public byte? NotificationType { get; set; }

		public List<NotificationAlert> Alerts { get; set; }

		public byte ProximityRange { get; set; }
		public Offer Offer { get; set; }

		public NotificationSchedule Schedule { get; set; }

		public List<BeaconSchedule> BeaconSchedule { get; set; }

		public int TotalNotifications { get; set; }

		public NotificationProduct NotificationProduct { get; set; }

		public decimal Rating { get; set; }

		public List<NotificationMessage> NotificationMessages { get; set; }
		public List<LiveKart.Entities.SurveyMessage> SurveyMessages { get; set; } 

		#endregion
	}

	public class NotificationAlert
	{
		#region Properties

		public long NotificationAlertId { get; set; }

		public long NotificationId { get; set; }

		[Display(Name = "Alert Header")]
		public string NotificationTitle { get; set; }

		[Display(Name = "Alert Message")]
		public string Description { get; set; }

		public string NotificationImage { get; set; }

		public byte ProximityRange { get; set; }

		public bool Active { get; set; }

		public string CreatedBy { get; set; }

		public DateTime? CreatedDate { get; set; }

		public string ModifiedBy { get; set; }

		public DateTime? ModifiedDate { get; set; }

		public long CompanyId { get; set; }

		#endregion
	}

	public class NotificationRating
	{
		#region Properties

		public long NotificationRatingId { get; set; }

		public long NotificationId { get; set; }

		public decimal Rate { get; set; }

		public DateTime? CreatedOn { get; set; }

		#endregion
	}

	public class NotificationBeaconMap
	{
		#region Properties

		public long NotificationBeaconMappingId { get; set; }

		[Display(Name = "Beacon Id")]
		public string BeaconId { get; set; }

		[Display(Name = "Campaign")]
		public long NotificationId { get; set; }
		public long CompanyId { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? CreatedDate { get; set; }

		#endregion
	}

	public class NotificationSchedule
	{

		#region Properties

		public long NotificationScheduleId { get; set; }
		public long NotificationId { get; set; }
		public long CompanyId { get; set; }

		[Display(Name = "Campaign Type")]
		public string NotificationType { get; set; }

		[Display(Name = "Schedule Days")]
		public string ScheduleDays { get; set; }
		public string[] Days { get; set; }
		[Display(Name = "Start Date")]
		public DateTime? StartDate { get; set; }
		[Display(Name = "End Date")]
		public DateTime? EndDate { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }

		[Display(Name = "Time")]
		public string StartTime { get; set; }

		[Display(Name = "Time")]
		public string EndTime { get; set; }

		#endregion
	}

	public class Offer
	{
		#region Properties

		public long OfferId { get; set; }
		public long NotificationId { get; set; }
		public string Title { get; set; }
		public string Description { get; set; }
		public string OfferImage { get; set; }
		public bool Active { get; set; }
		public string CreatedBy { get; set; }
		public DateTime? CreatedDate { get; set; }
		public string ModifiedBy { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public long CompanyId { get; set; }

		public string BarCode { get; set; }

		#endregion
	}

	public class NotificationProduct
	{

		#region Properties

		public long NotificationProductId { get; set; }

		public long NotificationId { get; set; }

		public long CompanyId { get; set; }

		[Display(Name = "Product Name")]
		public string ProductName { get; set; }

		public string Description { get; set; }


		public string Sizes { get; set; }

		public string[] ProductSizes { get; set; }

		public string Prices { get; set; }

		public string[] ProductPrices { get; set; }

		public string BarCode { get; set; }

		public string ProductImage { get; set; }

		public string CreatedBy { get; set; }

		public DateTime? CreatedDate { get; set; }

		public string ModifiedBy { get; set; }

		public DateTime? ModifiedDate { get; set; }

		public string VuforiaTargetId { get; set; }

		#endregion
	}

	public class BeaconSchedule
	{
		public long BeaconScheduleId { get; set; }

		public long CompanyId { get; set; }

		public long NotificationId { get; set; }

		public string BeaconId { get; set; }

		public DateTime FromDate { get; set; }

		public string StrFromDate { get; set; }

		public DateTime ToDate { get; set; }

		public string StrToDate { get; set; }

		public string Days { get; set; }

		public List<string> ScheduleDays { get; set; }

		public string CreatedBy { get; set; }

		public DateTime CreatedDate { get; set; }

		public string ModifiedBy { get; set; }

		public DateTime ModifiedDate { get; set; }

		public List<Beacon> Beacons { get; set; }
	}

	public class RestNotificationProduct : RestResponse
	{
		public NotificationProduct Product { get; set; }
	}

	public class NotificationMessage
	{
		public long NotificationMessageId { get; set; }
		public long NotificationId { get; set; }
		public string MessageHeader { get; set; }
		public string MessageShortDescription { get; set; }
		public string MessageThumbImage { get; set; }
		public string MessageImage { get; set; }
		public string MessageDescription { get; set; }
		public LiveKart.Entities.Enums.MessageType? NotificationType { get; set; }
		public string NotificationTitle { get; set; }
		public string NotificationDescription { get; set; }
		public short? ProximityRange { get; set; }
		public long StandardMessageId { get; set; }
		public long SurveyId { get; set; }
		public bool Disabled { get; set; }
		public StandardMessage StandardMessage { get; set; }
		public LiveKart.Entities.SurveyMessage SurveyMessage { get; set; }
		public LiveKart.Entities.OfferMessage OfferMessage { get; set; }
		public LiveKart.Entities.ReviewMessage ReviewMessage { get; set; }
		public LiveKart.Entities.RatingMessage RatingMessage { get; set; }
		public LiveKart.Entities.VideoMessage VideoMessage { get; set; }
		public LiveKart.Entities.GameMessage GameMessage { get; set; }
	}

	public class StandardMessage
	{
		public long StandardMessageId { get; set; }
		public string MessageHeader { get; set; }
		public string MessageShortDescription { get; set; }
		public string MessageThumbImage { get; set; }
		public string MessageImage { get; set; }
		public string MessageDescription { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
	}
}
