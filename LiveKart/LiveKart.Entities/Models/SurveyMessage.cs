using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Script.Serialization;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
	public class SurveyMessage : Entity
	{
		public SurveyMessage()
		{
			Questions = new List<SurveyQuestion>();
		}
		public long SurveyId { get; set; }
		[StringLength(100)]
		public string MessageHeader { get; set; }
		[StringLength(100)]
		public string MessageShortDescription { get; set; }
		[StringLength(300)]
		public string MessageDescription { get; set; }
		[NotMapped]
		public string MessageThumbImage { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }

		public virtual List<SurveyQuestion> Questions { get; set; }
	}

	public class SurveyQuestion : Entity
	{
		[Key]
		public long QuestionId { get; set; }
		[ForeignKey("Survey")]
		public long SurveyId { get; set; }
		public string Question { get; set; }
		public byte QuestionType { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }

		[ScriptIgnore]
		public virtual SurveyMessage Survey { get; set; }

		public virtual List<SurveyQuestionAnswer> Answers { get; set; }
		public virtual List<SurveyUserAnswer> UserAnswers { get; set; } 
	}

	public class SurveyQuestionAnswer : Entity
	{
		[Key]
		public long AnswerId { get; set; }
		[ForeignKey("SurveyQuestion")]
		public long QuestionId { get; set; }
		public string Answer { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }

		[ScriptIgnore]
		public virtual SurveyQuestion SurveyQuestion { get; set; }
	}

	public class SurveyUserAnswer : Entity
	{
		[Key]
		public long AnswerId { get; set; }
		[ForeignKey("SurveyQuestion")]
		public long QuestionId { get; set; }
		public long? SelectedAnswerId { get; set; }
		[NotMapped]
		public long[] SelectedAnswerIds { get; set; }
		public string Answer { get; set; }
		public long? UserId { get; set; }
		public DateTime? CreatedDate { get; set; }
		public DateTime? ModifiedDate { get; set; }
		public Guid? RecordId { get; set; }

		[ScriptIgnore]
		public virtual SurveyQuestion SurveyQuestion { get; set; }
	}
}
