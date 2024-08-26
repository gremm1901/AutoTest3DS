using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class FirstTokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("server_time")]
        public DateTime ServerTime { get; set; }

        [JsonPropertyName("expire_time")]
        public DateTime ExpireTime { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("SecondStepRequired")]
        public bool SecondStepRequired { get; set; }
    }
}
