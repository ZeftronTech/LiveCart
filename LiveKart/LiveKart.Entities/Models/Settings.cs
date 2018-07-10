using System.ComponentModel.DataAnnotations.Schema;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
	public class Settings : Entity
	{
		public long SettingId { get; set; }
		public long CompanyId { get; set; }
		public int CloseMinRSSI { get; set; }
		public int CloseMaxRSSI { get; set; }
		public int NearMinRSSI { get; set; }
		public int NearMaxRSSI { get; set; }
		public int FarMinRSSI { get; set; }
		public int FarMaxRSSI { get; set; }
		[NotMapped]
		public int DwellTime { get; set; }
		[NotMapped]
		public int SignalStrength { get; set; }
	}
}
