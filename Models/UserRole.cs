using System.Text.Json.Serialization;

namespace rbl_tracker.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UserRole
    {
        User = 0,
        Admin = 1
    }
}