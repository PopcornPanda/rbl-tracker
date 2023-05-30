namespace rbl_tracker.Dtos.Check
{
    public class GetRblCheckSimpleHistoryDto
    {
        public string? Host { get; set; }
        public RblLevel? Level { get; set; }
        public long CheckTime { get; set; } = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
        public List<Rbl.GetRblListingDto> Rbls { get; set; } = new List<Rbl.GetRblListingDto>();

    }
}