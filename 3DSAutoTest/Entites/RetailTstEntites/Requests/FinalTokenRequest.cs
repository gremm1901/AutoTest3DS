using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.requests
{
    public class FinalTokenRequest
    {
        [JsonPropertyName("usedChannel")]
        public string UsedChannel { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("returnLoginResult")]
        public string ReturnLoginResult { get; set; }

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        [JsonPropertyName("loginType")]
        public string LoginType { get; set; }
    }
}
