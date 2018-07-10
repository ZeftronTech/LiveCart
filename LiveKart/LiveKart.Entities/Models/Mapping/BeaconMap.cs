using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class BeaconMap : EntityTypeConfiguration<Beacon>
    {
        public BeaconMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.BeaconID)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.BeaconName)
                .HasMaxLength(45);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(45);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(45);

            this.Property(t => t.BatteryLevel)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl_m_Beacon");
            this.Property(t => t.BeaconID).HasColumnName("BeaconID");
            this.Property(t => t.BeaconName).HasColumnName("BeaconName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.BatteryLevel).HasColumnName("BatteryLevel");
            this.Property(t => t.Id).HasColumnName("Id");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Beacons)
                .HasForeignKey(d => d.CompanyID);

        }
    }
}
