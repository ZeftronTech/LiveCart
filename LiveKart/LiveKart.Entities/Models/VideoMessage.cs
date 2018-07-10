using System;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
	public partial class VideoMessage : Entity
	{
		public long VideoMessageId { get; set; }
		public string MessageHeader { get; set; }
		public string MessageShortDescription { get; set; }
		public string MessageImage { get; set; }
		public string MessageDescription { get; set; }
		public string VideoUrl { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }

	}
}
