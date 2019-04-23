namespace ZSZ.Service.Entities
{
    public class CommunityEntity
    {
        public string Name { get; set; }
        public long RegionId { get; set; }
        public virtual RegionEntity Region { get; set; }
        public string Location { get; set; }
        public string Traffic { get; set; }
        public int BuiltYear { get; set; }
    }
}