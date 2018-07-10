using System.Collections.Generic;
using System.Linq;
using Repository.Pattern.UnitOfWork;
using Service.Pattern;
using LiveKart.Entities;
using Repository.Pattern.Repositories;
using LiveKart.Repository;

namespace LiveKart.Service
{
	public class NotificationMessageService : Service<NotificationMessage>, INotificationMessageService
	{
		private readonly IRepository<NotificationMessage> _repository;
		private readonly IRepository<StandardMessage> _standartMessageRepo;
		private readonly INotificationService _notificationService;
		private readonly ISurveyService _surveyService;

		public NotificationMessageService(IRepository<NotificationMessage> repository,
			INotificationService notificationService,
			ISurveyService surveyService)
			: base(repository)
		{
			_repository = repository;
			_standartMessageRepo = repository.GetRepository<StandardMessage>();
			_notificationService = notificationService;
			_surveyService = surveyService;
		}

		public IQueryable<NotificationMessage> NotificationMessages()
		{
			return _repository.NotificationMessages();
		}

		public IEnumerable<NotificationMessage> GetByNotificationId(long id)
		{
			return GetByNotificationIdQuery(id).AsEnumerable();
		}

		public IQueryable<NotificationMessage> GetByNotificationIdQuery(long id)
		{
			return _repository.NotificationMessages().Where(x => x.NotificationId == id);
		}

		public NotificationMessage GetNotification(long id)
		{
			return _repository.GetRepository<NotificationMessage>()
				.Query(x => x.NotificationMessageId == id)
				.Include(s => s.SurveyMessage.Questions.Select(a => a.Answers))
				.Include(s => s.StandardMessage)
				.Include(s => s.ReviewMessage)
				.Include(s=> s.RatingMessage.RatingItems.Select(r=>r.RatingMessage.RatingItems))
				.Select().SingleOrDefault();
		}

		public long Add(NotificationMessage message)
		{
			return _repository.Add(message);
		}

		public IEnumerable<NotificationMessage> GetByBeaconNum(string id)
		{
			var notitications = _notificationService.GetByBeaconNum(id).ToList();

			var messages = _repository.Query()
			                           .Include(m => m.Notification)
			                           .Include(m => m.StandardMessage)
			                           .Include(m => m.SurveyMessage.Questions.Select(q=>q.Answers))
			                           .Select().Where(m => notitications.Contains(m.Notification)).ToList();
			return messages;
		}
		public void AddUserAnswers(List<SurveyUserAnswer> answers)
		{
			_surveyService.AddUserAnswers(answers);
		}

		#region Standart Message
		public StandardMessage FindStandartMessage(long id)
		{
			return _repository.GetRepository<StandardMessage>().Find(id);
		}


		public void InsertStandartMessage(StandardMessage entity)
		{
			_repository.GetRepository<StandardMessage>().Insert(entity);
		}

		public void UpdateStandartMessage(StandardMessage entity)
		{
			_repository.GetRepository<StandardMessage>().Update(entity);
		}
		#endregion

		#region Servey Message
		public SurveyMessage FindSurveyMessage(long id)
		{
			return _repository.GetRepository<SurveyMessage>().Query()
			                  .Include(s => s.Questions.Select(q => q.Answers))
							  .Include(s => s.Questions.Select(q => q.UserAnswers))
							  .Select().FirstOrDefault(s => s.SurveyId == id);
		}
		public void InsertSurveyMessage(SurveyMessage entity)
		{
			_repository.GetRepository<SurveyMessage>().Insert(entity);
		}

		public void UpdateSurveyMessage(SurveyMessage entity)
		{
			_repository.GetRepository<SurveyMessage>().Update(entity);
		}

		public void InsertSurveyQuestion(SurveyQuestion entity)
		{
			_surveyService.Insert(entity);
		}

		public void UpdateSurveyQuestion(SurveyQuestion entity)
		{
			_surveyService.Update(entity);
		}

		public void DeleteSurveyQuestion(SurveyQuestion entity)
		{
			_surveyService.DeleteQuestion(entity);
		}

		public void InsertSurveyAnswer(SurveyQuestionAnswer entity)
		{
			_surveyService.Insert(entity);
		}

		public void UpdateSurveyAnswer(SurveyQuestionAnswer entity)
		{
			_surveyService.Update(entity);
		}


		public void InsertSurveyAnswers(IEnumerable<SurveyQuestionAnswer> entities)
		{
			_surveyService.InsertRange(entities);
		}

		public void DeleteSurveyAnswer(SurveyQuestionAnswer entity)
		{
			_surveyService.DeleteAnswer(entity);
		}

		public IEnumerable<SurveyUserAnswer> GetSurveyUserAnswerBySurvey(long surveyId)
		{
			return _surveyService.GetUserAnswersBySurvey(surveyId);
		}

		public void DeleteSurveyUserAnswer(SurveyUserAnswer entity)
		{
			_surveyService.DeleteUserAnswer(entity);
		}

		#endregion

		#region Review Message
		public ReviewMessage FindReviewMessage(long id)
		{
			return _repository.GetRepository<ReviewMessage>().Find(id);
		}
		public void InsertReviewMessage(ReviewMessage entity)
		{
			_repository.GetRepository<ReviewMessage>().Insert(entity);
		}

		public void UpdateReviewMessage(ReviewMessage entity)
		{
			_repository.GetRepository<ReviewMessage>().Update(entity);
		}

		public IEnumerable<UserReview> GetUserReviews(long reviewId)
		{
			return _repository.GetRepository<UserReview>()
				.Queryable().Where(r => r.ReviewMessageId == reviewId).AsEnumerable();
		}
		#endregion

		#region Rating Message

		public RatingMessage FindRatingMessage(long id)
		{
			return  _repository.GetRepository<RatingMessage>().Query()
				.Include(m => m.RatingItems)
				.Select()
				.First(m=> m.RatingMessageId == id);
		}

		public void InsertRatingMessage(RatingMessage entity)
		{
			_repository.GetRepository<RatingMessage>().Insert(entity);
		}

		public void UpdateRatingMessage(RatingMessage entity)
		{
			var ratingRepo = _repository.GetRepository<RatingMessage>();
			var ratingItemsRepo = _repository.GetRepository<RatingItem>();
			var itemsIds =
				ratingItemsRepo.Queryable()
				               .Where(item => item.RatingMessageId == entity.RatingMessageId)
				               .Select(item => item.RatingItemId).ToList();
			itemsIds.ForEach(item => ratingItemsRepo.Delete(item));
			entity.RatingItems.ForEach(item =>
				{
					item.RatingItemId = 0;
					item.RatingMessageId = entity.RatingMessageId;
				});
			ratingItemsRepo.InsertRange(entity.RatingItems);
			ratingRepo.Update(entity);
		}

		public void InsertRatingItems(IEnumerable<RatingItem> items)
		{
			_repository.GetRepository<RatingItem>().InsertRange(items);
		}

		public IEnumerable<RatingItem> FindRatingItems(long ratingMessageId)
		{
			return _repository.GetRepository<RatingItem>().Queryable()
			                  .Where(item => item.RatingMessageId == ratingMessageId)
							  .AsEnumerable();
		}

		public void InsertUserRatingItems(IEnumerable<UserRatingItem> ratingItems)
		{
			_repository.GetRepository<UserRatingItem>().InsertRange(ratingItems);
		}

		public IEnumerable<UserRatingItem> GetUserRatingItemsByRatingId(long ratingId)
		{
			var ratingItems = FindRatingItems(ratingId).ToList();
			return _repository.GetRepository<UserRatingItem>()
			           .Query()
			           .Select()
			           .Where(i => ratingItems.Select(ri => ri.RatingItemId).Contains(i.RatingItemId))
			           .AsEnumerable();
		}

		#endregion

		#region Offer Message

		public OfferMessage FindOfferMessage(long id)
		{
			return _repository.GetRepository<OfferMessage>().Find(id);
		}

		public void InsertOfferMessage(OfferMessage message)
		{
			_repository.GetRepository<OfferMessage>().Insert(message);
		}

		public void UpdateOfferMessage(OfferMessage message)
		{
			_repository.GetRepository<OfferMessage>().Update(message);
		}

		#endregion 
	}
}
