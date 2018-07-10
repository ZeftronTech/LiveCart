using System.Collections.Generic;
using LiveKart.Entities;
using System.Linq;
using Service.Pattern;

namespace LiveKart.Service
{
	public interface ISurveyService : IService<SurveyMessage> 
	{
		SurveyMessage ById(long id);
		IQueryable Surveys();
		long Add(SurveyMessage message);
		void Update(SurveyMessage message);
		void Delete(long id);
		SurveyMessage ByIdDetailed(long id);
		IEnumerable<SurveyQuestion> GetQuestions(long surveyId);
		IEnumerable<SurveyQuestionAnswer> GetAnswers(long questionId);
		IEnumerable<SurveyUserAnswer> GetUserAnswersBySurvey(long surveyId);
		void AddUserAnswer(SurveyUserAnswer answer);
		void AddUserAnswers(List<SurveyUserAnswer> answers);

		void Insert(SurveyQuestion entity);
		void Insert(SurveyQuestionAnswer entity);
		void Update(SurveyQuestion entity);
		void Update(SurveyQuestionAnswer entity);
		void InsertRange(IEnumerable<SurveyQuestionAnswer> entity);

		void DeleteAnswer(SurveyQuestionAnswer entity);
		void DeleteQuestion(SurveyQuestion entity);
		void DeleteUserAnswer(SurveyUserAnswer entity);

	}
}
