using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class ReviewMessageMap : EntityTypeConfiguration<ReviewMessage>
	{
		public ReviewMessageMap()
		{
			// Primary Key
			HasKey(t => t.ReviewMessageId);

			// Properties
			Property(t => t.MessageHeader)
				.HasMaxLength(100);

			Property(t => t.MessageShortDescription)
				.HasMaxLength(100);

			Property(t => t.MessageDescription)
				.HasMaxLength(300);


			Property(t => t.CreatedDate);
			Property(t => t.ModifiedDate);

			// Table & Column Mappings
			this.ToTable("tbl_m_reviewmessage");
			this.Property(t => t.ReviewMessageId).HasColumnName("ReviewMessageId");
			this.Property(t => t.MessageHeader).HasColumnName("MessageHeader");
			this.Property(t => t.MessageShortDescription).HasColumnName("MessageShortDescription");
			this.Property(t => t.MessageDescription).HasColumnName("MessageDescription");
			this.Property(t => t.MessageImage).HasColumnName("MessageImage");
			this.Property(t => t.City).HasColumnName("City");
			this.Property(t => t.State).HasColumnName("State");
			this.Property(t => t.ScreenName).HasColumnName("ScreenName");
			this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}
