
namespace rbl_tracker.Dtos.Domain
{
    public class NewDomainDto
    {
        public string Name { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public User? Owner { get; set; }

    }
}