using System.Data.Entity;
using LiveKart.Entities.Models.Mapping;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities
{
	public partial class LiveKartEntities : DataContext
	{
		static LiveKartEntities()
		{
			Database.SetInitializer<LiveKartEntities>(null);
		}

		public LiveKartEntities()
			: base("Name=LiveKartEntities")
		{
		}

		public DbSet<Asset> Assets { get; set; }
		public DbSet<AssetCategory> AssetCategories { get; set; }
		public DbSet<Beacon> Beacons { get; set; }
		public DbSet<BeaconDeployment> BeaconDeployments { get; set; }
		public DbSet<BeaconSchedule> BeaconSchedules { get; set; }
		public DbSet<Company> Companies { get; set; }
		public DbSet<Country> Countries { get; set; }
		public DbSet<Notification> Notifications { get; set; }
		public DbSet<NotificationAlert> NotificationAlerts { get; set; }
		public DbSet<NotificationBeaconMap> NotificationBeaconMaps { get; set; }
		public DbSet<NotificationMessage> NotificationMessages { get; set; }
		public DbSet<NotificationProduct> NotificationProducts { get; set; }
		public DbSet<NotificationRating> NotificationRatings { get; set; }
		public DbSet<NotificationSchedule> NotificationSchedules { get; set; }
		public DbSet<Offer> Offers { get; set; }
		public DbSet<StandardMessage> StandardMessages { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<SurveyMessage> SurveyMessage { get; set; }
		public DbSet<ReviewMessage> ReviewMessage { get; set; }
		public DbSet<UserReview> UserReviews { get; set; }
		public DbSet<RatingMessage> RatingMessage { get; set; }
		public DbSet<RatingItem> RatingItem { get; set; }
		public DbSet<UserRatingItem> UserRatingItem { get; set; }
		public DbSet<OfferMessage> OfferMessage { get; set; }
		public DbSet<Settings> Settings { get; set; }


		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new AssetMap());
			modelBuilder.Configurations.Add(new AssetCategoryMap());
			modelBuilder.Configurations.Add(new BeaconMap());
			modelBuilder.Configurations.Add(new BeaconDeploymentMap());
			modelBuilder.Configurations.Add(new BeaconScheduleMap());
			modelBuilder.Configurations.Add(new CompanyMap());
			modelBuilder.Configurations.Add(new CountryMap());
			modelBuilder.Configurations.Add(new NotificationMap());
			modelBuilder.Configurations.Add(new NotificationAlertMap());
			modelBuilder.Configurations.Add(new NotificationBeaconMapMap());
			modelBuilder.Configurations.Add(new NotificationMessageMap());
			modelBuilder.Configurations.Add(new NotificationProductMap());
			modelBuilder.Configurations.Add(new NotificationRatingMap());
			modelBuilder.Configurations.Add(new NotificationScheduleMap());
			modelBuilder.Configurations.Add(new OfferMap());
			modelBuilder.Configurations.Add(new StandardMessageMap());
			modelBuilder.Configurations.Add(new UserMap());
			modelBuilder.Configurations.Add(new SurveyMessageMap());
			modelBuilder.Configurations.Add(new SurveyQuestionMap());
			modelBuilder.Configurations.Add(new SurveyQuestionAnswersMap());
			modelBuilder.Configurations.Add(new SurveyUserAnswersMap());
			modelBuilder.Configurations.Add(new ReviewMessageMap());
			modelBuilder.Configurations.Add(new UserReviewMap());
			modelBuilder.Configurations.Add(new RatingMessageMap());
			modelBuilder.Configurations.Add(new RatingItemMap());
			modelBuilder.Configurations.Add(new UserRatingItemMap());
			modelBuilder.Configurations.Add(new OfferMessageMap());
			modelBuilder.Configurations.Add(new SettingsMap());
		}
	}
}
