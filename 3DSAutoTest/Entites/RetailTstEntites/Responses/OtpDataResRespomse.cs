using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class OtpDataResRespomse
    {
        [JsonPropertyName("number")]
        public int Number { get; set; }

        [JsonPropertyName("otpEnvelopeId")]
        public int OtpEnvelopeId { get; set; }
    }
}
