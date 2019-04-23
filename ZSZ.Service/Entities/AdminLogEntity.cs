namespace ZSZ.Service.Entities
{
    public class AdminLogEntity:BaseEntity
    {
        public long UserID { get; set; }
        public virtual UserEntity User { get; set; }
        public string Message { get; set; }
    }
}