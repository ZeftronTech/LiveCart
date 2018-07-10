using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class NotificationBeaconMapMap : EntityTypeConfiguration<NotificationBeaconMap>
    {
        public NotificationBeaconMapMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationBeaconMappingID);

            // Properties
            this.Property(t => t.BeaconID)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
			this.ToTable("tbl_m_NotificationBeaconMap");
            this.Property(t => t.NotificationBeaconMappingID).HasColumnName("NotificationBeaconMappingID");
            this.Property(t => t.NotificationID).HasColumnName("NotificationID");
            this.Property(t => t.BeaconID).HasColumnName("BeaconID");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");

            // Relationships
            this.HasRequired(t => t.Beacon)
                .WithMany(t => t.NotificationBeaconMap)
                .HasForeignKey(d => d.BeaconID);

        }
    }
}
