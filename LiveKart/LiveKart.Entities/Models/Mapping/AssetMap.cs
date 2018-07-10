using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class AssetMap : EntityTypeConfiguration<Asset>
    {
        public AssetMap()
        {
            // Primary Key
            this.HasKey(t => t.AssetID);

            // Properties
            this.Property(t => t.AssetName)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.Address)
                .HasMaxLength(100);

            this.Property(t => t.State)
                .HasMaxLength(50);

            this.Property(t => t.City)
                .HasMaxLength(50);

            this.Property(t => t.ZipCode)
                .HasMaxLength(50);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl_m_Asset");
            this.Property(t => t.AssetID).HasColumnName("AssetID");
            this.Property(t => t.AssetCategoryID).HasColumnName("AssetCategoryID");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.AssetName).HasColumnName("AssetName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.ZipCode).HasColumnName("ZipCode");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");

            // Relationships
            this.HasRequired(t => t.AssetCategory)
                .WithMany(t => t.Assets)
                .HasForeignKey(d => d.AssetCategoryID);

        }
    }
}
