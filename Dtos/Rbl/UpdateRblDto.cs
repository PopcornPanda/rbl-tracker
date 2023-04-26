namespace rbl_tracker.Dtos.Rbl
{
    public class UpdateRblDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public RblType Type { get; set; } = RblType.Rbl;
        public RblLevel Level { get; set; } = RblLevel.Normal;
        public string DelistUrl { get; set; } = string.Empty;
        public long UpdateTime {get; set;} = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
    }
}