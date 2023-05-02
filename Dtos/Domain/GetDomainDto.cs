namespace rbl_tracker.Dtos.Domain
{
    public class GetDomainDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public Auth.GetUserDto? Owner { get; set; }
        public long CreateTime {get; set;} = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        public long UpdateTime {get; set;} = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();

    }
}