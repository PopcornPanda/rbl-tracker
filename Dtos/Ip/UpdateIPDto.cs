namespace rbl_tracker.Dtos.Ip
{
    public class UpdateIpDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public User? Owner { get; set; }
        public long UpdateTime {get; set;} = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
    }

}