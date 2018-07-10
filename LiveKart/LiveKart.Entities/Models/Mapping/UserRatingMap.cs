using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class UserRatingItemMap : EntityTypeConfiguration<UserRatingItem>
	{
		public UserRatingItemMap()
		{
			// Primary Key
			HasKey(t => t.UserRatingItemId);

			// Table & Column Mappings
			ToTable("UserRatingItem");
			Property(t => t.UserRatingItemId).HasColumnName("UserRatingItemId");
			Property(t => t.RatingItemId).HasColumnName("RatingItemId");
			Property(t => t.Mark).HasColumnName("Mark");
			Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
			Property(t => t.UserId).HasColumnName("UserId");
		}
	}
}
