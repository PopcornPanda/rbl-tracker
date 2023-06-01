namespace rbl_tracker.Dtos.Auth
{
    public class GetSimpleUserDto
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
    }
}