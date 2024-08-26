using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.requests
{
    public class FirstTokenRequest
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("requestId")]
        public string RequestId { get; set; }

        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        [JsonPropertyName("returnLoginResult")]
        public string ReturnLoginResult { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("grant_type")]
        public string GrantType { get; set; }

        [JsonPropertyName("loginType")]
        public string LoginType { get; set; }
    }
}
