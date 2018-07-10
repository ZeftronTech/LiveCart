using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class StandardMessageMap : EntityTypeConfiguration<StandardMessage>
    {
        public StandardMessageMap()
        {
            // Primary Key
            HasKey(t => t.StandardMessageId);

            // Properties
            Property(t => t.MessageHeader)
                .HasMaxLength(100);

            Property(t => t.MessageShortDescription)
                .HasMaxLength(100);

            Property(t => t.MessageThumbImage)
                .HasMaxLength(250);

            Property(t => t.MessageImage)
                .HasMaxLength(250);

            Property(t => t.MessageDescription)
                .HasMaxLength(300);

            // Table & Column Mappings
			ToTable("tbl_m_StandardMessage");
            Property(t => t.StandardMessageId).HasColumnName("StandardMessageId");
            Property(t => t.MessageHeader).HasColumnName("MessageHeader");
            Property(t => t.MessageShortDescription).HasColumnName("MessageShortDescription");
            Property(t => t.MessageThumbImage).HasColumnName("MessageThumbImage");
            Property(t => t.MessageImage).HasColumnName("MessageImage");
            Property(t => t.MessageDescription).HasColumnName("MessageDescription");
            Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
