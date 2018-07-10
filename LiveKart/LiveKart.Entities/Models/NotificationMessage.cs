using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public partial class NotificationMessage : Entity
    {
        public long NotificationMessageId { get; set; }
        public long NotificationId { get; set; }
        public string MessageThumbImage { get; set; }
        public Nullable<byte> NotificationType { get; set; }
		[Required(ErrorMessage = "Notification Title Is Required")]
		[StringLength(100)]
        public string NotificationTitle { get; set; }
		[StringLength(250)]
        public string NotificationDescription { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
		[ForeignKey("StandardMessage")]
        public Nullable<long> StandardMessageId { get; set; }
		[ForeignKey("OfferMessage")]
        public Nullable<long> OfferId { get; set; }
        public Nullable<long> SurveyId { get; set; }
		[ForeignKey("ReviewMessage")]
        public Nullable<long> ProductReviewId { get; set; }
		[ForeignKey("RatingMessage")]
        public Nullable<long> ProductRatingId { get; set; }
        public Nullable<long> VideoId { get; set; }
        public Nullable<long> GameId { get; set; }
        public Nullable<byte> ProximityRange { get; set; }
		public bool Disabled { get; set; }
		[IgnoreDataMember]
        public virtual Notification Notification { get; set; }
        public virtual StandardMessage StandardMessage { get; set; }
		public virtual SurveyMessage SurveyMessage { get; set; }
		public virtual ReviewMessage ReviewMessage { get; set; }
		public virtual RatingMessage RatingMessage { get; set; }
		public virtual OfferMessage OfferMessage { get; set; }


		[NotMapped]
		public virtual VideoMessage VideoMessage { get; set; }
		[NotMapped]
		public virtual GameMessage GameMessage { get; set; }
    }
}
