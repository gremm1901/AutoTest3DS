using System.Security.Principal;
using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class AvatarResponse
    {
        [JsonPropertyName("MimeType")]
        public string MimeType { get; set; }

        [JsonPropertyName("ImageData")]
        public string ImageData { get; set; }

        [JsonPropertyName("Hash")]
        public string Hash { get; set; }

        [JsonPropertyName("IsAvatarAllowed")]
        public bool IsAvatarAllowed { get; set; }
    }
}
