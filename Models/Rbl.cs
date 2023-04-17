namespace rbl_tracker.Models
{
    public class Rbl
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public RblType Type { get; set; } = RblType.Rbl;
        public RblLevel Level { get; set; } = RblLevel.Normal;
        public string DelistUrl { get; set; } = string.Empty;
    }
}