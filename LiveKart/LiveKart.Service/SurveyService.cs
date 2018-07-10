using System.Collections.Generic;
using LiveKart.Entities;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;
using System.Linq;
using Service.Pattern;

namespace LiveKart.Service
{
	public class SurveyService : Service<SurveyMessage>, ISurveyService
	{
		private IRepository<SurveyMessage> _repository;
		private IRepository<SurveyQuestion> _questionRepo;
		private IRepository<SurveyQuestionAnswer> _answerRepo;
		private IRepository<SurveyUserAnswer> _userAnswerRepo;

		public SurveyService(IRepository<SurveyMessage> repository)
			:base(repository)
		{
			_repository = repository;
			_questionRepo = _repository.GetRepository<SurveyQuestion>();
			_answerRepo = _repository.GetRepository<SurveyQuestionAnswer>();
			_userAnswerRepo = _repository.GetRepository<SurveyUserAnswer>();
		}

		public SurveyMessage ById(long id)
		{
			return _repository.Find(id);
		}

		public SurveyMessage ByIdDetailed(long id)
		{
			var survey = ById(id);
			survey.Questions = GetQuestions(id).ToList();
			return survey;
		}

		public IQueryable Surveys()
		{
			return _repository.Queryable();
		}

		public long Add(SurveyMessage survey)
		{
			_repository.Insert(survey);
			return survey.SurveyId;
		}

		public void Update(SurveyMessage survey)
		{
			_repository.Update(survey);
		}

		public void Delete(long id)
		{
			_repository.Delete(id);
		}

		public IEnumerable<SurveyQuestion> GetQuestions(long surveyId)
		{
			//TODO: Reimplement with only one DB call
			var questions =  _questionRepo.Queryable().Where(q => q.SurveyId == surveyId).ToList();
			questions.ForEach(q => q.Answers = GetAnswers(q.QuestionId).ToList());
			return questions;
		}

		public IEnumerable<SurveyQuestionAnswer> GetAnswers(long questionId)
		{
			return _answerRepo.Queryable().Where(a => a.QuestionId == questionId).AsEnumerable();
		}

		public IEnumerable<SurveyUserAnswer> GetUserAnswersBySurvey(long surveyId)
		{
			return _userAnswerRepo.Query(a => a.SurveyQuestion.SurveyId == surveyId)
			                      .Include(a => a.SurveyQuestion.Answers)
			                      .Select();
		}

		public void AddUserAnswer(SurveyUserAnswer answer)
		{
			_userAnswerRepo.Insert(answer);
		}

		public void AddUserAnswers(List<SurveyUserAnswer> answers)
		{
			foreach (var answer in answers.Where(answer => answer.SelectedAnswerId != null || answer.Answer != null))
			{
				_userAnswerRepo.Insert(answer);
			}
		}

		public void Insert(SurveyQuestionAnswer entity)
		{
			_answerRepo.Insert(entity);
		}

		public void InsertRange(IEnumerable< SurveyQuestionAnswer> entity)
		{
			_answerRepo.InsertRange(entity);
		}

		public void DeleteAnswer(SurveyQuestionAnswer entity)
		{
			_answerRepo.Delete(entity);
		}

		public void DeleteQuestion(SurveyQuestion entity)
		{
			_questionRepo.Delete(entity);
		}

		public void DeleteUserAnswer(SurveyUserAnswer entity)
		{
			_userAnswerRepo.Delete(entity);
		}

		public void Update(SurveyQuestionAnswer entity)
		{
			_answerRepo.Update(entity);
		}

		public void Update(SurveyQuestion entity)
		{
			_questionRepo.Update(entity);
		}

		public void Insert(SurveyQuestion entity)
		{
			_questionRepo.Insert(entity);
		}
	}
}
