namespace ZSZ.Service.Entities
{
    public class HouseAttachmentEntity:BaseEntity
    {
        public long HouseId { get; set; }
        public virtual HouseEntity House { get; set; }
        public long AttachmentId { get; set; }
        public virtual AttachmentEntity Attachment { get; set; }
    }
}