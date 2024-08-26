using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class SaltResponse
    {
        [JsonPropertyName("sessionSalt")]
        public string SessionSalt { get; set; }

        [JsonPropertyName("requestId")]
        public string RequestId { get; set; }

        [JsonPropertyName("passwordSalt")]
        public string PasswordSalt { get; set; }
    }
}
