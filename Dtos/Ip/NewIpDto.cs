
namespace rbl_tracker.Dtos.Ip
{
    public class NewIpDto
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public User? Owner { get; set; }
    }
}