namespace rbl_tracker.Dtos.Auth
{
    public class GetUserDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<Dtos.Host.GetSimpleHostDto>? Hosts { get; set; }
        public UserRole Role { get; set; } = UserRole.User;
        public long CreateTime {get; set;} = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        public long UpdateTime {get; set;} = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
    }
}