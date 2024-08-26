using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class DictItemResponse
    {
        [JsonPropertyName("display")]
        public string Display { get; set; }

        [JsonPropertyName("displayX")]
        public string DisplayX { get; set; }

        [JsonPropertyName("value")]
        public ValueResponse Value { get; set; }

        [JsonPropertyName("comment")]
        public string Comment { get; set; }
    }
}
