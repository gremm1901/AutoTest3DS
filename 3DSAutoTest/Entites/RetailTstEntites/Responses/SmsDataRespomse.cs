using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class SmsDataRespomse
    {
        [JsonPropertyName("serverDateUtc")]
        public DateTime ServerDateUtc { get; set; }

        [JsonPropertyName("interval")]
        public string Interval { get; set; }

        [JsonPropertyName("duration")]
        public string Duration { get; set; }

        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("sentDateUtc")]
        public DateTime SentDateUtc { get; set; }
    }
}
