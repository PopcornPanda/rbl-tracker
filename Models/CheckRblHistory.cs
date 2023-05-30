namespace rbl_tracker.Models
{
    public class CheckRblHistory
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public Guid? Host { get; set; }
        public List<Models.Rbl> Rbls { get; set; } = new List<Models.Rbl>();
        public RblLevel? Level { get; set; }
        public long CheckTime { get; set; } = new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds();
    }

}
