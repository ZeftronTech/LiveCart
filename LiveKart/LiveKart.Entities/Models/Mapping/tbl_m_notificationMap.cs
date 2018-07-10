using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class NotificationMap : EntityTypeConfiguration<Notification>
    {
        public NotificationMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationID);

            // Properties
            this.Property(t => t.CreatedBy)
                .HasMaxLength(45);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(45);

            this.Property(t => t.NotificationTitle)
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            this.Property(t => t.NotificationImage)
                .HasMaxLength(250);

            // Table & Column Mappings
			this.ToTable("tbl_m_Notification");
            this.Property(t => t.NotificationID).HasColumnName("NotificationID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.NotificationType).HasColumnName("NotificationType");
            this.Property(t => t.NotificationTitle).HasColumnName("NotificationTitle");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.NotificationImage).HasColumnName("NotificationImage");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Notification)
                .HasForeignKey(d => d.CompanyID);

        }
    }
}
