using System.Data.Entity.ModelConfiguration;
using System.Runtime.CompilerServices;
using ZSZ.Service.Entities;

namespace ZSZ.Service.ModelConfig
{
    public class AdminUserConfig:EntityTypeConfiguration<AdminUserEntity>
    {
        public AdminUserConfig()
        {
            ToTable("T_AdminUsers");
            Property(e => e.Name).IsRequired().HasMaxLength(32);
            Property(e => e.Email).IsOptional().HasMaxLength(64);
            Property(e => e.PhoneNum).IsRequired().HasMaxLength(32);
            Property(e => e.PasswordSalt).IsRequired().HasMaxLength(32);
            Property(e => e.PasswordHash).IsRequired().HasMaxLength(32);
            HasOptional(e=>e.City).WithMany().HasForeignKey(e=>e.CityId).WillCascadeOnDelete(false);
            HasOptional(e=>e.Role).WithMany().HasForeignKey(e=>e.RoleId).WillCascadeOnDelete(false);
            Property(e => e.LoginErrorTimes).IsRequired();
            Property(e => e.LastLoginErrorDateTime).IsRequired();
        }
    }
}