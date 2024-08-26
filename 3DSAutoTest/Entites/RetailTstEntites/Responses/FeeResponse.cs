using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class FeeResponse
    {
        [JsonPropertyName("fee")]
        public int Fee { get; set; }

        [JsonPropertyName("period")]
        public int Period { get; set; }
    }
}
