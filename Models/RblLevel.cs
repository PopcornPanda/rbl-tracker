using System.Text.Json.Serialization;

namespace rbl_tracker.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RblLevel
    {
        Low = 0,
        Normal = 1,
        High = 2,
        Critical = 3
    }
}