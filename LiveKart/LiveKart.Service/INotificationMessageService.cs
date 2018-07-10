using System;
using System.Collections.Generic;
using LiveKart.Entities;
using System.Linq;
using Service.Pattern;

namespace LiveKart.Service
{
	public interface INotificationMessageService : IService<NotificationMessage> 
	{
		IQueryable<NotificationMessage> NotificationMessages();
		IEnumerable<NotificationMessage> GetByNotificationId(long id);
		IEnumerable<NotificationMessage> GetByBeaconNum(string id);
		NotificationMessage GetNotification(long id);
		long Add(NotificationMessage message);
		void AddUserAnswers(List<SurveyUserAnswer> answers);

		StandardMessage FindStandartMessage(long id);
		void InsertStandartMessage(StandardMessage entity);
		void UpdateStandartMessage(StandardMessage entity);

		SurveyMessage FindSurveyMessage(long id);

		void InsertSurveyMessage(SurveyMessage entity);
		void UpdateSurveyMessage(SurveyMessage entity);

		void InsertSurveyQuestion(SurveyQuestion entity);
		void UpdateSurveyQuestion(SurveyQuestion entity);
		void DeleteSurveyQuestion(SurveyQuestion entity);


		void InsertSurveyAnswer(SurveyQuestionAnswer entity );
		void UpdateSurveyAnswer(SurveyQuestionAnswer entity);
		void InsertSurveyAnswers(IEnumerable< SurveyQuestionAnswer> entities);
		void DeleteSurveyAnswer(SurveyQuestionAnswer entity);

		IEnumerable<SurveyUserAnswer> GetSurveyUserAnswerBySurvey(long surveyId);
		void DeleteSurveyUserAnswer(SurveyUserAnswer entity);
		
		ReviewMessage FindReviewMessage(long id);
		void InsertReviewMessage(ReviewMessage entity);
		void UpdateReviewMessage(ReviewMessage entity);
		IEnumerable<UserReview> GetUserReviews(long reviewId);

		RatingMessage FindRatingMessage(long id);
		void InsertRatingMessage(RatingMessage entity);
		void UpdateRatingMessage(RatingMessage entity);
		void InsertRatingItems(IEnumerable<RatingItem> items);
		IEnumerable<RatingItem> FindRatingItems(long ratingMessageId);
		void InsertUserRatingItems(IEnumerable<UserRatingItem> ratingItems);
		IEnumerable<UserRatingItem> GetUserRatingItemsByRatingId(long ratingId);

		OfferMessage FindOfferMessage(long id);
		void InsertOfferMessage(OfferMessage message);
		void UpdateOfferMessage(OfferMessage message);
	}
}
