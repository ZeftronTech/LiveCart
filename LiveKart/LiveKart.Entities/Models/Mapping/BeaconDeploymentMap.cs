using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class BeaconDeploymentMap : EntityTypeConfiguration<BeaconDeployment>
    {
        public BeaconDeploymentMap()
        {
            // Primary Key
            this.HasKey(t => t.BeaconDeploymentID);

            // Properties
            this.Property(t => t.CreatedBy)
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("tbl_m_BeaconDeployment");
            this.Property(t => t.BeaconDeploymentID).HasColumnName("BeaconDeploymentID");
            this.Property(t => t.AssetID).HasColumnName("AssetID");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.BeaconID).HasColumnName("BeaconID");

            // Relationships
            this.HasRequired(t => t.Asset)
                .WithMany(t => t.BeaconDeployments)
                .HasForeignKey(d => d.AssetID);
            this.HasOptional(t => t.Beacon)
                .WithMany(t => t.BeaconDeployments)
                .HasForeignKey(d => d.BeaconID);
            this.HasRequired(t => t.Company)
                .WithMany(t => t.BeaconDeployments)
                .HasForeignKey(d => d.CompanyID);

        }
    }
}
