namespace rbl_tracker.Models
{
    public class Host
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
        public User? Owner { get; set; }
        public bool isDomain { get; set; } = false;
        public long CreateTime { get; set; } = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        public long UpdateTime { get; set; } = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
    }
}