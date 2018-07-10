using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace LiveKart.Entities
{
	public partial class Notification
	{
		[NotMapped]
		public NotificationSchedule Schedule
		{
			get { return NotificationSchedules.FirstOrDefault(); }
			set { NotificationSchedules.Add(value); }
		}

		[NotMapped]
		public int NotificationCount
		{
			get;
			set;
		}
	}
}
