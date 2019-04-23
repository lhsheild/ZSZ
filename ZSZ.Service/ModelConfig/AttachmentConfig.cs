using System.Data.Entity.ModelConfiguration;
using ZSZ.Service.Entities;

namespace ZSZ.Service.ModelConfig
{
    public class AttachmentConfig:EntityTypeConfiguration<AttachmentEntity>
    {
        public AttachmentConfig()
        {
            ToTable("T_Attachments");
            Property(e => e.Name).IsRequired().HasMaxLength(32);
            Property(e => e.IconName).IsRequired().HasMaxLength(32);
        }
    }
}