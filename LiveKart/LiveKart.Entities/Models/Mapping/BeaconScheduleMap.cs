using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class BeaconScheduleMap : EntityTypeConfiguration<BeaconSchedule>
    {
        public BeaconScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.BeaconScheduleID);

            // Properties
            this.Property(t => t.Days)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(45);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("tbl_m_BeaconSchedule");
            this.Property(t => t.BeaconScheduleID).HasColumnName("BeaconScheduleID");
            this.Property(t => t.NotificationID).HasColumnName("NotificationID");
            this.Property(t => t.FromDate).HasColumnName("FromDate");
            this.Property(t => t.ToDate).HasColumnName("ToDate");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.BeaconID).HasColumnName("BeaconID");

            // Relationships
            this.HasOptional(t => t.Beacon)
                .WithMany(t => t.BeaconSchedules)
                .HasForeignKey(d => d.BeaconID);
            this.HasOptional(t => t.Company)
                .WithMany(t => t.BeaconSchedules)
                .HasForeignKey(d => d.CompanyID);
            this.HasRequired(t => t.Notification)
                .WithMany(t => t.BeaconSchedules)
                .HasForeignKey(d => d.NotificationID);

        }
    }
}
