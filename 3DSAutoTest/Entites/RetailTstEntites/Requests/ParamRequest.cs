using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.requests
{
    public class ParamRequest
    {
        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }

        [JsonPropertyName("value")]
        public object Value { get; set; }
    }
}
