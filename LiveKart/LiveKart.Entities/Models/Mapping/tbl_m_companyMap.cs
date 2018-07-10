using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class CompanyMap : EntityTypeConfiguration<Company>
    {
        public CompanyMap()
        {
            // Primary Key
            this.HasKey(t => t.CompanyID);

            // Properties
            this.Property(t => t.CompanyID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ContactPerson)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Image)
                .HasMaxLength(300);

            this.Property(t => t.Address1)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.Address2)
                .HasMaxLength(250);

            this.Property(t => t.State)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.City)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Zip)
                .HasMaxLength(10);

            this.Property(t => t.Phone)
                .HasMaxLength(15);

            this.Property(t => t.CreatedBy)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ModifiedBy)
                .HasMaxLength(50);

            this.Property(t => t.VuforiaServerAccessKey)
                .HasMaxLength(50);

            this.Property(t => t.VuforiaServerSecretKey)
                .HasMaxLength(50);

            this.Property(t => t.VuforiaClientAccessKey)
                .HasMaxLength(50);

            this.Property(t => t.VuforiaClientSecretKey)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl_m_Company");
            this.Property(t => t.CompanyID).HasColumnName("CompanyID");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.ContactPerson).HasColumnName("ContactPerson");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Image).HasColumnName("Image");
            this.Property(t => t.Address1).HasColumnName("Address1");
            this.Property(t => t.Address2).HasColumnName("Address2");
            this.Property(t => t.State).HasColumnName("State");
            this.Property(t => t.City).HasColumnName("City");
            this.Property(t => t.Zip).HasColumnName("Zip");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.Phone).HasColumnName("Phone");
            this.Property(t => t.Active).HasColumnName("Active");
            this.Property(t => t.CreatedBy).HasColumnName("CreatedBy");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.ModifiedBy).HasColumnName("ModifiedBy");
            this.Property(t => t.ModifiedDate).HasColumnName("ModifiedDate");
            this.Property(t => t.VuforiaServerAccessKey).HasColumnName("VuforiaServerAccessKey");
            this.Property(t => t.VuforiaServerSecretKey).HasColumnName("VuforiaServerSecretKey");
            this.Property(t => t.VuforiaClientAccessKey).HasColumnName("VuforiaClientAccessKey");
            this.Property(t => t.VuforiaClientSecretKey).HasColumnName("VuforiaClientSecretKey");

            // Relationships
            this.HasRequired(t => t.Login)
                .WithOptional(t => t.Company);

        }
    }
}
