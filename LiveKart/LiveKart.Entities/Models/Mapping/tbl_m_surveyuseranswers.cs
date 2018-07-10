using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class SurveyUserAnswersMap : EntityTypeConfiguration<SurveyUserAnswer>
	{
		public SurveyUserAnswersMap()
		{
			// Primary Key
			HasKey(t => t.AnswerId);
			// Properties
			Property(t => t.QuestionId);
			Property(t => t.SelectedAnswerId);
			Property(t => t.Answer);
			Property(t => t.UserId);
			Property(t => t.CreatedDate);
			Property(t => t.ModifiedDate);

			// Table & Column Mappings
			ToTable("tbl_m_surveyuseranswers");
			Property(t => t.AnswerId).HasColumnName("AnswerId");
			Property(t => t.QuestionId).HasColumnName("QuestionId");
			Property(t => t.SelectedAnswerId).HasColumnName("SelectedAnswerId");
			Property(t => t.Answer).HasColumnName("Answer");
			Property(t => t.UserId).HasColumnName("UserId");
			Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
			Property(t => t.RecordId).HasColumnName("RecordId");
		}
	}
}
