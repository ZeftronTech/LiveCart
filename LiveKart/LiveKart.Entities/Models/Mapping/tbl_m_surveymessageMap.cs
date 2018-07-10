using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class SurveyMessageMap : EntityTypeConfiguration<SurveyMessage>
	{
		public SurveyMessageMap()
		{
			// Primary Key
			HasKey(t => t.SurveyId);

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
			this.ToTable("tbl_m_surveymessage");
			this.Property(t => t.SurveyId).HasColumnName("SurveyId");
			this.Property(t => t.MessageHeader).HasColumnName("Header");
			this.Property(t => t.MessageShortDescription).HasColumnName("ShortDescription");
			this.Property(t => t.MessageDescription).HasColumnName("FullDescription");
			this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			// Relationships
			//this.HasMany(t => t.Questions)
			//	.WithRequired(t => t.Survey)
			//	.HasForeignKey(d => d.SurveyId);
		}
	}
}
