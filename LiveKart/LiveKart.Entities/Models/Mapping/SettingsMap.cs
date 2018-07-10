using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class SettingsMap : EntityTypeConfiguration<Settings>
	{
		public SettingsMap()
		{
			// Primary Key
			HasKey(t => t.SettingId);

			// Table & Column Mappings
			ToTable("Settings");
			Property(t => t.SettingId).HasColumnName("SettingId");
			Property(t => t.CompanyId).HasColumnName("CompanyId");
			Property(t => t.CloseMinRSSI).HasColumnName("CloseMinRSSI");
			Property(t => t.CloseMaxRSSI).HasColumnName("CloseMaxRSSI");
			Property(t => t.NearMinRSSI).HasColumnName("NearMinRSSI");
			Property(t => t.NearMaxRSSI).HasColumnName("NearMaxRSSI");
			Property(t => t.FarMinRSSI).HasColumnName("FarMinRSSI");
			Property(t => t.FarMaxRSSI).HasColumnName("FarMaxRSSI");
		}
	}
}
