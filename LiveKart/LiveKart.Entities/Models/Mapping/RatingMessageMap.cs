using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class RatingMessageMap : EntityTypeConfiguration<RatingMessage>
	{
		public RatingMessageMap()
		{
			// Primary Key
			this.HasKey(t => t.RatingMessageId);

			// Properties
			this.Property(t => t.MessageHeader)
				.HasMaxLength(100);

			this.Property(t => t.MessageShortDescription)
				.HasMaxLength(100);

			this.Property(t => t.MessageImage)
				.HasMaxLength(250);
			Property(t => t.MessageDescription)
				.HasMaxLength(300);

			// Table & Column Mappings
			this.ToTable("RatingMessage");
			this.Property(t => t.RatingMessageId).HasColumnName("RatingMessageId");
			this.Property(t => t.MessageHeader).HasColumnName("MessageHeader");
			this.Property(t => t.MessageShortDescription).HasColumnName("MessageShortDescription");
			this.Property(t => t.MessageImage).HasColumnName("MessageImage");
			this.Property(t => t.MessageDescription).HasColumnName("MessageDescription");
			this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}
