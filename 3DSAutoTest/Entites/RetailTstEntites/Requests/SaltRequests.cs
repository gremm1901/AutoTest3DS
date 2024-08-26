using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.requests
{
    public class SaltRequests
    {
        [JsonPropertyName("clientIdentifier")]
        public string ClientIdentifier { get; set; }

        [JsonPropertyName("loginType")]
        public string LoginType { get; set; }
    }
}
