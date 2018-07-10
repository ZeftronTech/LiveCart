using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class UserReviewMap : EntityTypeConfiguration<UserReview>
	{
		public UserReviewMap()
		{
			// Primary Key
			HasKey(t => t.UserReviewId);

			// Properties
			Property(t => t.Title)
				.HasMaxLength(100);

			Property(t => t.Review)
				.HasMaxLength(300);

			Property(t => t.ScreenName)
				.HasMaxLength(300);

			Property(t => t.City)
				.HasMaxLength(100);


			Property(t => t.CreatedDate);
			Property(t => t.ModifiedDate);

			// Table & Column Mappings
			ToTable("tbl_m_userreview");
			Property(t => t.UserReviewId).HasColumnName("UserReviewId");
			Property(t => t.ReviewMessageId).HasColumnName("ReviewMessageId");
			Property(t => t.Title).HasColumnName("Title");
			Property(t => t.Review).HasColumnName("Review");
			Property(t => t.ScreenName).HasColumnName("ScreenName");
			Property(t => t.City).HasColumnName("City");
			Property(t => t.StateId).HasColumnName("StateId");
			Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}
