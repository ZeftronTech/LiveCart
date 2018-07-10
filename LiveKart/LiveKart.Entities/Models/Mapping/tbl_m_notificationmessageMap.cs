using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class NotificationMessageMap : EntityTypeConfiguration<NotificationMessage>
    {
        public NotificationMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationMessageId);

            // Properties
			//this.Property(t => t.MessageHeader)
			//	.HasMaxLength(100);

			//this.Property(t => t.MessageShortDescription)
			//	.HasMaxLength(100);

            this.Property(t => t.MessageThumbImage)
                .HasMaxLength(250);

			//this.Property(t => t.MessageImage)
			//	.HasMaxLength(250);

			//this.Property(t => t.MessageDescription)
			//	.HasMaxLength(300);

            this.Property(t => t.NotificationTitle)
                .HasMaxLength(100);

            this.Property(t => t.NotificationDescription)
                .HasMaxLength(250);

            // Table & Column Mappings
			this.ToTable("tbl_m_NotificationMessage");
            this.Property(t => t.NotificationMessageId).HasColumnName("NotificationMessageId");
            this.Property(t => t.NotificationId).HasColumnName("NotificationId");
			//this.Property(t => t.MessageHeader).HasColumnName("MessageHeader");
			//this.Property(t => t.MessageShortDescription).HasColumnName("MessageShortDescription");
            this.Property(t => t.MessageThumbImage).HasColumnName("MessageThumbImage");
			//this.Property(t => t.MessageImage).HasColumnName("MessageImage");
			//this.Property(t => t.MessageDescription).HasColumnName("MessageDescription");
            this.Property(t => t.NotificationType).HasColumnName("NotificationType");
            this.Property(t => t.NotificationTitle).HasColumnName("NotificationTitle");
            this.Property(t => t.NotificationDescription).HasColumnName("NotificationDescription");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.StandardMessageId).HasColumnName("StandardMessageId");
            this.Property(t => t.OfferId).HasColumnName("OfferId");
            this.Property(t => t.SurveyId).HasColumnName("SurveyId");
            this.Property(t => t.ProductReviewId).HasColumnName("ProductReviewId");
            this.Property(t => t.ProductRatingId).HasColumnName("ProductRatingId");
            this.Property(t => t.VideoId).HasColumnName("VideoId");
            this.Property(t => t.GameId).HasColumnName("GameId");
            this.Property(t => t.ProximityRange).HasColumnName("ProximityRange");
			this.Property(t => t.Disabled).HasColumnName("Disabled");

			//// Relationships
			//this.HasOptional(t => t.StandardMessage)
			//	.WithMany(t => t.NotificationMessage)
			//	.HasForeignKey(d => d.StandardMessageId);

        }
    }
}
