namespace rbl_tracker.Models
{
    public class Ip
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = "";
        public string Address { get; set; } = "";
    }
}