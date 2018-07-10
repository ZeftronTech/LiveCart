using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using LiveKart.Entities.Models.Mapping;
using Repository.Pattern.Ef6;

namespace LiveKart.Entities.Models
{
	public partial class KlivekartdpdContext : DataContext
	{
		static KlivekartdpdContext()
		{
			Database.SetInitializer<KlivekartdpdContext>(null);
		}

		public KlivekartdpdContext()
			: base("Name=KlivekartdpdContext")
		{
		}

		public DbSet<sysdiagram> sysdiagrams { get; set; }
		public DbSet<Asset> Asset { get; set; }
		public DbSet<AssetCategory> AssetCategory { get; set; }
		public DbSet<Beacon> Beacon { get; set; }
		public DbSet<BeaconDeployment> BeaconDeployment { get; set; }
		public DbSet<BeaconSchedule> BeaconSchedule { get; set; }
		public DbSet<Company> Company { get; set; }
		public DbSet<Country> Country { get; set; }
		public DbSet<Login> Login { get; set; }
		public DbSet<Notification> Notification { get; set; }
		public DbSet<NotificationAlert> NotificationAlert { get; set; }
		public DbSet<NotificationBeaconMap> NotificationBeaconMap { get; set; }
		public DbSet<NotificationMessage> NotificationMessage { get; set; }
		public DbSet<NotificationProduct> NotificationProduct { get; set; }
		public DbSet<NotificationRating> NotificationRating { get; set; }
		public DbSet<NotificationSchedule> NotificationSchedule { get; set; }
		public DbSet<Offer> Offer { get; set; }
		public DbSet<StandardMessage> StandardMessage { get; set; }
		public DbSet<SurveyMessage> SurveyMessage { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Configurations.Add(new sysdiagramMap());
			modelBuilder.Configurations.Add(new AssetMap());
			modelBuilder.Configurations.Add(new AssetcategoryMap());
			modelBuilder.Configurations.Add(new BeaconMap());
			modelBuilder.Configurations.Add(new BeaconDeploymentMap());
			modelBuilder.Configurations.Add(new BeaconScheduleMap());
			modelBuilder.Configurations.Add(new CompanyMap());
			modelBuilder.Configurations.Add(new CountryMap());
			modelBuilder.Configurations.Add(new LoginMap());
			modelBuilder.Configurations.Add(new NotificationMap());
			modelBuilder.Configurations.Add(new NotificationAlertMap());
			modelBuilder.Configurations.Add(new NotificationBeaconMapMap());
			modelBuilder.Configurations.Add(new NotificationMessageMap());
			modelBuilder.Configurations.Add(new NotificationProductMap());
			modelBuilder.Configurations.Add(new NotificationRatingMap());
			modelBuilder.Configurations.Add(new NotificationScheduleMap());
			modelBuilder.Configurations.Add(new OfferMap());
			modelBuilder.Configurations.Add(new StandardMessageMap());
			modelBuilder.Configurations.Add(new SurveyMessageMap());
			modelBuilder.Configurations.Add(new SurveyQuestionMap());
			modelBuilder.Configurations.Add(new SurveyQuestionAnswersMap());
			modelBuilder.Configurations.Add(new SurveyUserAnswersMap());

		}
	}
}
