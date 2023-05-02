namespace rbl_tracker.Dtos.Ip
{
    public class UpdateIpDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
    }

}