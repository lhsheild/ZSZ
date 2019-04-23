using System;

namespace ZSZ.Service.Entities
{
    public class AdminUserEntity:BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNum { get; set;}
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public long CityId { get; set; }
        public virtual CityEntity City { get; set; }
        public long RoleId { get; set; }
        public virtual RoleEntity Role { get; set; }
        public int LoginErrorTimes { get; set; }
        public DateTime LastLoginErrorDateTime { get; set; }
    }
}