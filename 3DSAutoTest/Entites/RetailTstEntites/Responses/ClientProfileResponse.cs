using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class ClientProfileResponse
    {
        [JsonPropertyName("RemoteAccessLevel")]
        public int RemoteAccessLevel { get; set; }

        [JsonPropertyName("IsLiteOperationAccess")]
        public bool IsLiteOperationAccess { get; set; }

        [JsonPropertyName("ClientId")]
        public int ClientId { get; set; }

        [JsonPropertyName("Login")]
        public string Login { get; set; }

        [JsonPropertyName("Token")]
        public string Token { get; set; }

        [JsonPropertyName("FirstName")]
        public string FirstName { get; set; }

        [JsonPropertyName("LastName")]
        public string LastName { get; set; }

        [JsonPropertyName("MiddleName")]
        public string MiddleName { get; set; }

        [JsonPropertyName("Avatar")]
        public AvatarResponse Avatar { get; set; }

        [JsonPropertyName("ClientSegment")]
        public int ClientSegment { get; set; }

        [JsonPropertyName("ResidenceType")]
        public int ResidenceType { get; set; }

        [JsonPropertyName("Sex")]
        public int Sex { get; set; }

        [JsonPropertyName("Email")]
        public string Email { get; set; }

        [JsonPropertyName("ServicePhone")]
        public string ServicePhone { get; set; }
    }
}
