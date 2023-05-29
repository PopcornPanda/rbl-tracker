namespace rbl_tracker.Dtos.Host
{
    public class UpdateHostDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool isDomain { get; set; } = false;
    }

}