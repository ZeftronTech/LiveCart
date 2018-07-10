using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LiveKart.Entities
{
	public class Enums
	{
		public enum MessageType
		{ 
			[Display(Name = "Standard message")]
			StandardMessage = 0,
			[Display(Name = "Offer")]
			Offer = 1,
			[Display(Name = "Survey message")]
			SurveyMessage = 2,
			[Display(Name="Product Review")]
			ReviewMessage = 3,
			[Display(Name = "Product Rating")]
			RatingMessage = 4,
			[Display(Name = "Video")]
			VideoMessage = 5,
			[Display(Name = "Game")]
			GameMessage = 6
		}

		public enum SurveyQuestionType
		{
			SingleChoise = 0,
			MultipleChoise = 1,
			SingleTextBox = 2,
			CommentBox = 3
		}

		public enum State
		{
			[Description("Alabama")]
			AL,

			[Description("Alaska")]
			AK,

			[Description("Arkansas")]
			AR,

			[Description("Arizona")]
			AZ,

			[Description("California")]
			CA,

			[Description("Colorado")]
			CO,

			[Description("Connecticut")]
			CT,

			[Description("D.C.")]
			DC,

			[Description("Delaware")]
			DE,

			[Description("Florida")]
			FL,

			[Description("Georgia")]
			GA,

			[Description("Hawaii")]
			HI,

			[Description("Iowa")]
			IA,

			[Description("Idaho")]
			ID,

			[Description("Illinois")]
			IL,

			[Description("Indiana")]
			IN,

			[Description("Kansas")]
			KS,

			[Description("Kentucky")]
			KY,

			[Description("Louisiana")]
			LA,

			[Description("Massachusetts")]
			MA,

			[Description("Maryland")]
			MD,

			[Description("Maine")]
			ME,

			[Description("Michigan")]
			MI,

			[Description("Minnesota")]
			MN,

			[Description("Missouri")]
			MO,

			[Description("Mississippi")]
			MS,

			[Description("Montana")]
			MT,

			[Description("North Carolina")]
			NC,

			[Description("North Dakota")]
			ND,

			[Description("Nebraska")]
			NE,

			[Description("New Hampshire")]
			NH,

			[Description("New Jersey")]
			NJ,

			[Description("New Mexico")]
			NM,

			[Description("Nevada")]
			NV,

			[Description("New York")]
			NY,

			[Description("Oklahoma")]
			OK,

			[Description("Ohio")]
			OH,

			[Description("Oregon")]
			OR,

			[Description("Pennsylvania")]
			PA,

			[Description("Rhode Island")]
			RI,

			[Description("South Carolina")]
			SC,

			[Description("South Dakota")]
			SD,

			[Description("Tennessee")]
			TN,

			[Description("Texas")]
			TX,

			[Description("Utah")]
			UT,

			[Description("Virginia")]
			VA,

			[Description("Vermont")]
			VT,

			[Description("Washington")]
			WA,

			[Description("Wisconsin")]
			WI,

			[Description("West Virginia")]
			WV,

			[Description("Wyoming")]
			WY

		}

		public enum ProximityRange
		{
			Anywhere = 0,
			Close = 1,
			Near = 2,
			Far = 3
		}

		public enum NotificationProximityType //Notification.NotificationType field
		{
			Anywhere = 0,
			ProximityBased = 1
		}
	}
}
