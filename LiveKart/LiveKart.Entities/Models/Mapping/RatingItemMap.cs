using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
	public class RatingItemMap : EntityTypeConfiguration<RatingItem>
	{
		public RatingItemMap()
		{
			// Primary Key
			this.HasKey(t => t.RatingItemId);

			// Properties
			this.Property(t => t.ItemName)
				.HasMaxLength(100);

			// Table & Column Mappings
			this.ToTable("RatingItem");
			this.Property(t => t.RatingItemId).HasColumnName("RatingItemId");
			this.Property(t => t.RatingMessageId).HasColumnName("RatingMessageId");
			this.Property(t => t.ItemName).HasColumnName("ItemName");
			this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
			this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
		}
	}
}
