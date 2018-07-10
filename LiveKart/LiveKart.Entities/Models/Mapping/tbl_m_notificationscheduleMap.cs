using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class NotificationScheduleMap : EntityTypeConfiguration<NotificationSchedule>
    {
        public NotificationScheduleMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationScheduleID);

            // Properties
            this.Property(t => t.NotificationType)
                .HasMaxLength(45);

            this.Property(t => t.ScheduleDays)
                .HasMaxLength(45);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(45);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(45);

            // Table & Column Mappings
			this.ToTable("tbl_m_NotificationSchedule");
            this.Property(t => t.NotificationScheduleID).HasColumnName("NotificationScheduleID");
            this.Property(t => t.NotificationID).HasColumnName("NotificationID");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.NotificationType).HasColumnName("NotificationType");
            this.Property(t => t.ScheduleDays).HasColumnName("ScheduleDays");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.EndDate).HasColumnName("EndDate");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.NotificationSchedule)
                .HasForeignKey(d => d.CompanyID);
            this.HasOptional(t => t.Notification)
                .WithMany(t => t.NotificationSchedule)
                .HasForeignKey(d => d.NotificationID);

        }
    }
}
