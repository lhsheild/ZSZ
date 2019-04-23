using System;

namespace ZSZ.Service.Entities
{
    public class HouseAppointmentEntity
    {
        public long UserId { get; set; }
        public virtual UserEntity User { get; set; }
        public string Name { get; set; }
        public string PhoneNum { get; set; }
        public DateTime VisitDate { get; set; }
        public long HouseId { get; set; }
        public virtual HouseEntity House { get; set; }
        public string Status { get; set; }
        public long FollowAdminUserId { get; set; }
        public virtual AdminUserEntity FollowAdminUser { get; set; }
        public DateTime FollowDateTime { get; set; }
    }
}