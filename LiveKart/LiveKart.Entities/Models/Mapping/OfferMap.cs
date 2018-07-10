using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class OfferMap : EntityTypeConfiguration<Offer>
    {
        public OfferMap()
        {
            // Primary Key
            this.HasKey(t => t.OfferID);

            // Properties
            this.Property(t => t.Title)
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            this.Property(t => t.OfferImage)
                .HasMaxLength(250);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(45);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("tbl_m_Offer");
            this.Property(t => t.OfferID).HasColumnName("OfferID");
            this.Property(t => t.NotificationID).HasColumnName("NotificationID");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.OfferImage).HasColumnName("OfferImage");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.Active).HasColumnName("Active");

            // Relationships
            this.HasRequired(t => t.Company)
                .WithMany(t => t.Offers)
                .HasForeignKey(d => d.CompanyID);
            this.HasRequired(t => t.Notification)
                .WithMany(t => t.Offers)
                .HasForeignKey(d => d.NotificationID);

        }
    }
}
