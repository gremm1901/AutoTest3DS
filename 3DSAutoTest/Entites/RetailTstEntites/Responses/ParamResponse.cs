using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class ParamResponse
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("help")]
        public string Help { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }
        
        [JsonPropertyName("value")]
        public ValueResponse Value { get; set; }

        [JsonPropertyName("visibility")]
        public int Visibility { get; set; }
    }
}
