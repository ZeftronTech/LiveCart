using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class NotificationProductMap : EntityTypeConfiguration<NotificationProduct>
    {
        public NotificationProductMap()
        {
            // Primary Key
            this.HasKey(t => t.NotificationProductID);

            // Properties
            this.Property(t => t.ProductName)
                .HasMaxLength(100);

            this.Property(t => t.Description)
                .HasMaxLength(250);

            this.Property(t => t.ProductImage)
                .HasMaxLength(250);

            this.Property(t => t.Sizes)
                .HasMaxLength(100);

            this.Property(t => t.Prices)
                .HasMaxLength(100);

            this.Property(t => t.CreatedBy)
                .HasMaxLength(45);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(45);

            this.Property(t => t.BarCode)
                .HasMaxLength(50);

            // Table & Column Mappings
			this.ToTable("tbl_m_NotificationProduct");
            this.Property(t => t.NotificationProductID).HasColumnName("NotificationProductID");
            this.Property(t => t.NotificationID).HasColumnName("NotificationID");
            this.Property(t => t.ProductName).HasColumnName("ProductName");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.ProductImage).HasColumnName("ProductImage");
            this.Property(t => t.Sizes).HasColumnName("Sizes");
            this.Property(t => t.Prices).HasColumnName("Prices");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.BarCode).HasColumnName("BarCode");
        }
    }
}
