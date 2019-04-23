using System.Data.Entity.ModelConfiguration;
using ZSZ.Service.Entities;

namespace ZSZ.Service.ModelConfig
{
    public class AdminLogConfig:EntityTypeConfiguration<AdminLogEntity>
    {
        public AdminLogConfig()
        {
            ToTable("T_AdminLogs");
            HasRequired(e=>e.User).WithMany().HasForeignKey(e=>e.UserID).WillCascadeOnDelete(false);
            Property(e => e.Message).IsRequired();
        }
    }
}