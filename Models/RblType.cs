using System.Text.Json.Serialization;

namespace rbl_tracker.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RblType
    {
        Rbl = 0,
        Surbl = 1
    }
}