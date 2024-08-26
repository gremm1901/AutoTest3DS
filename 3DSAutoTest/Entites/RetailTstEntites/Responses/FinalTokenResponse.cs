using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class FinalTokenResponse
    {
        [JsonPropertyName("access_token")]
        public string AccessToken { get; set; }

        [JsonPropertyName("refresh_token")]
        public string RefreshToken { get; set; }

        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        [JsonPropertyName("server_time")]
        public DateTime ServerTime { get; set; }

        [JsonPropertyName("expire_time")]
        public DateTime ExpireTime { get; set; }

        [JsonPropertyName("token_type")]
        public string TokenType { get; set; }

        [JsonPropertyName("ClientProfile")]
        public ClientProfileResponse ClientProfile { get; set; }

        [JsonPropertyName("DkoRequiredMode")]
        public int DkoRequiredMode { get; set; }

        [JsonPropertyName("IsNewRulesConfirmationRequired")]
        public bool IsNewRulesConfirmationRequired { get; set; }

        [JsonPropertyName("IsPushEnabled")]
        public bool IsPushEnabled { get; set; }

        [JsonPropertyName("IsContactInfoUpdateRequired")]
        public bool IsContactInfoUpdateRequired { get; set; }
    }
}
