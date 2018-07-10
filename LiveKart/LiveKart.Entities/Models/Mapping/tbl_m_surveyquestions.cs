using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class SurveyQuestionMap : EntityTypeConfiguration<SurveyQuestion>
	{
		public SurveyQuestionMap()
		{
			// Primary Key
			HasKey(t => t.QuestionId);
			// Properties
			Property(t => t.SurveyId);
			Property(t => t.Question).HasMaxLength(200);
			Property(t => t.QuestionType);
			Property(t => t.CreatedDate);
			Property(t => t.ModifiedDate);

			// Table & Column Mappings
			ToTable("tbl_m_surveyquestions");
			Property(t => t.QuestionId).HasColumnName("QuestionId");
			Property(t => t.SurveyId).HasColumnName("SurveyId");
			Property(t => t.Question).HasColumnName("Question");
			Property(t => t.QuestionType).HasColumnName("QuestionType");
			Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

			//HasRequired(t => t.Survey)
			//	.WithMany(t => t.Questions)
			//	.HasForeignKey(d => d.SurveyId);

			//HasMany(t => t.Answers)
			//	.WithOptional(t => t.SurveyQuestion)
			//	.HasForeignKey(d => d.QuestionId);
		}
	}
}
