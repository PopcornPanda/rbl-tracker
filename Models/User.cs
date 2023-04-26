namespace rbl_tracker.Models
{
    public class User
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = string.Empty;
        public byte[] PaswordHash { get; set; } = new byte[0];
        public byte[] PaswordSalt { get; set; } = new byte[0];
        public string Email { get; set; } = string.Empty;
        public List<Ip>? Ips { get; set; }
        public List<Domain>? Domains { get; set; }
        public long CreateTime {get; set;} = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        public long UpdateTime {get; set;} = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
    }
}