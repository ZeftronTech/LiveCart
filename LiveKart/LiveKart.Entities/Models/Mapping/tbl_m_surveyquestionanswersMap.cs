using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class SurveyQuestionAnswersMap : EntityTypeConfiguration<SurveyQuestionAnswer>
	{
		public SurveyQuestionAnswersMap()
		{
			// Primary Key
			HasKey(t => t.AnswerId);
			// Properties
			Property(t => t.Answer)
				.HasMaxLength(100);
			Property(t => t.QuestionId);
			Property(t => t.CreatedDate);
			Property(t => t.ModifiedDate);

			// Table & Column Mappings
			ToTable("tbl_m_surveyquestionanswers");
			Property(t => t.AnswerId).HasColumnName("AnswerId");
			Property(t => t.Answer).HasColumnName("Answer");
			Property(t => t.QuestionId).HasColumnName("QuestionId");
			Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}
