using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class StandardMessageMap : EntityTypeConfiguration<StandardMessage>
    {
        public StandardMessageMap()
        {
            // Primary Key
            this.HasKey(t => t.StandardMessageId);

            // Properties
            this.Property(t => t.MessageHeader)
                .HasMaxLength(100);

            this.Property(t => t.MessageShortDescription)
                .HasMaxLength(100);

            this.Property(t => t.MessageDescription)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("tbl_m_StandardMessage");
            this.Property(t => t.StandardMessageId).HasColumnName("StandardMessageId");
            this.Property(t => t.MessageHeader).HasColumnName("MessageHeader");
            this.Property(t => t.MessageShortDescription).HasColumnName("MessageShortDescription");
            this.Property(t => t.MessageThumbImage).HasColumnName("MessageThumbImage");
            this.Property(t => t.MessageImage).HasColumnName("MessageImage");
            this.Property(t => t.MessageDescription).HasColumnName("MessageDescription");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
        }
    }
}
