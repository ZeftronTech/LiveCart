using System;
using System.ComponentModel.DataAnnotations;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
    public class StandardMessage : Entity
    {
        public long StandardMessageId { get; set; }
		[StringLength(100)]
        public string MessageHeader { get; set; }
		[StringLength(100)]
        public string MessageShortDescription { get; set; }
        public string MessageThumbImage { get; set; }
        public string MessageImage { get; set; }
		[StringLength(300)]
        public string MessageDescription { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
    }
}
