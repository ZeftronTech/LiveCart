using System;
using System.ComponentModel.DataAnnotations;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
	public class OfferMessage : Entity
	{
		public long OfferMessageId { get; set; }
		[StringLength(300)]
		public string MessageHeader { get; set; }
		public string MessageShortDescription { get; set; }
		public string MessageImage { get; set; }
		public string MessageDescription { get; set; }
		public DateTime? ValidFrom { get; set; }
		public DateTime? ValidTo { get; set; }
		public Nullable<System.DateTime> CreatedDate { get; set; }
		public Nullable<System.DateTime> ModifiedDate { get; set; }
	}
}
