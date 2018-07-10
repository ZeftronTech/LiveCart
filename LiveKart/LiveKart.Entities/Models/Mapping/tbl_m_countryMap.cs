using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class CountryMap : EntityTypeConfiguration<Country>
    {
        public CountryMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CountryID, t.CountryName });

            // Properties
            this.Property(t => t.CountryID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CountryName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.CountryCode2)
                .HasMaxLength(45);

            this.Property(t => t.CountryCode3)
                .HasMaxLength(45);

            // Table & Column Mappings
            this.ToTable("tbl_m_Country");
            this.Property(t => t.CountryID).HasColumnName("CountryID");
            this.Property(t => t.CountryName).HasColumnName("CountryName");
            this.Property(t => t.CountryCode2).HasColumnName("CountryCode2");
            this.Property(t => t.CountryCode3).HasColumnName("CountryCode3");
        }
    }
}
