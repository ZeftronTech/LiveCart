using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Script.Serialization;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
	public class RatingMessage : Entity
	{
		public long RatingMessageId { get; set; }
		[StringLength(100)]
		public string MessageHeader { get; set; }
		[StringLength(100)]
		public string MessageShortDescription { get; set; }
		public string MessageImage { get; set; }
		[StringLength(300)]
		public string MessageDescription { get; set; }
		public List<RatingItem> RatingItems { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
	}

	public class RatingItem : Entity
	{
		public long RatingItemId { get; set; }
		[ForeignKey("RatingMessage")]
		public long RatingMessageId { get; set; }
		public string ItemName { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		[ScriptIgnore]
		public virtual RatingMessage RatingMessage { get; set; }
		public virtual IEnumerable<UserRatingItem> UserRatingItems { get; set; }
	}

	public class UserRatingItem : Entity
	{
		public long UserRatingItemId { get; set; }
		[ForeignKey("RatingItem")]
		public long RatingItemId { get; set; }
		public byte Mark { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public Guid UserId { get; set; }
		[ScriptIgnore]
		public virtual RatingItem RatingItem { get; set; }
		
	}
}
