using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace LiveKart.Entities.Models.Mapping
{
    public class LoginMap : EntityTypeConfiguration<Login>
    {
        public LoginMap()
        {
            // Primary Key
            this.HasKey(t => t.LoginID);

            // Properties
            this.Property(t => t.UserName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Password)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("tbl_m_Login");
            this.Property(t => t.LoginID).HasColumnName("LoginID");
            this.Property(t => t.UserName).HasColumnName("UserName");
            this.Property(t => t.Email).HasColumnName("Email");
            this.Property(t => t.Password).HasColumnName("Password");
            this.Property(t => t.RoleType).HasColumnName("RoleType");
            this.Property(t => t.LastLogin).HasColumnName("LastLogin");
            this.Property(t => t.IsLocked).HasColumnName("IsLocked");
            this.Property(t => t.InvalidAttempts).HasColumnName("InvalidAttempts");
        }
    }
}
