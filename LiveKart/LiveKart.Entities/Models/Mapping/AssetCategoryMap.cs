using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class AssetCategoryMap : EntityTypeConfiguration<AssetCategory>
    {
        public AssetCategoryMap()
        {
            // Primary Key
            this.HasKey(t => t.AssetCategoryID);

            // Properties
            this.Property(t => t.CategoryName)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl_m_AssetCategory");
            this.Property(t => t.AssetCategoryID).HasColumnName("AssetCategoryID");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.CategoryName).HasColumnName("CategoryName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithMany(t => t.AssetCategories)
                .HasForeignKey(d => d.CompanyID);

        }
    }
}
