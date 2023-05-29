namespace rbl_tracker.Dtos.Host
{
    public class GetSimpleHostDto
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public bool isDomain { get; set; } = false;

    }
}