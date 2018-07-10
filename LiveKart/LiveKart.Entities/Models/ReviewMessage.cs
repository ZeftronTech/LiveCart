using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
	public partial class ReviewMessage : Entity
	{
		[Key]
		public long ReviewMessageId { get; set; }
		[StringLength(100)]
		public string MessageHeader { get; set; }
		[StringLength(100)]
		public string MessageShortDescription { get; set; }
		public string MessageImage { get; set; }
		[StringLength(300)]
		public string MessageDescription { get; set; }
		public bool ScreenName { get; set; }
		public bool City { get; set; }
		public bool State { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
	}

	public class UserReview : Entity
	{
		[Key]
		public long UserReviewId { get; set; }
		[ForeignKey("ReviewMessage")]
		public long ReviewMessageId { get; set; }
		public string Title { get; set; }
		public string Review { get; set; }
		[Display(Name="ScreenName")]
		public string ScreenName { get; set; }
		[Display(Name="City")]
		public string City { get; set; }
		[Display(Name="State")]
		public int? StateId { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public virtual ReviewMessage ReviewMessage { get; set; }
	}
}
