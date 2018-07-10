using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class NotificationRatingMap : EntityTypeConfiguration<NotificationRating>
    {
        public NotificationRatingMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationRatingId);

            // Properties
            // Table & Column Mappings
            this.ToTable("tbl_m_NotificationRating");
            this.Property(t => t.NotificationRatingId).HasColumnName("NotificationRatingId");
            this.Property(t => t.NotificationId).HasColumnName("NotificationId");
            this.Property(t => t.Rate).HasColumnName("Rate");
            this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Notification)
                .WithMany(t => t.NotificationRatings)
                .HasForeignKey(d => d.NotificationId);

        }
    }
}
