using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class OfferMessageMap : EntityTypeConfiguration<OfferMessage>
	{
		public OfferMessageMap()
		{
			// Primary Key
			HasKey(t => t.OfferMessageId);

			// Properties
			Property(t => t.MessageHeader)
			    .HasMaxLength(300);

			// Table & Column Mappings
			ToTable("OfferMessage");
			Property(t => t.OfferMessageId).HasColumnName("OfferMessageId");
			Property(t => t.MessageHeader).HasColumnName("MessageHeader");
			Property(t => t.MessageShortDescription).HasColumnName("MessageShortDescription");
			Property(t => t.MessageImage).HasColumnName("MessageImage");
			Property(t => t.MessageDescription).HasColumnName("MessageDescription");
			Property(t => t.ValidFrom).HasColumnName("ValidFrom");
			Property(t => t.ValidTo).HasColumnName("ValidTo");
			Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}
