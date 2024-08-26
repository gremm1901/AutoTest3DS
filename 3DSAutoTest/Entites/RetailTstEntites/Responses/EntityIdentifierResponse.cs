using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class EntityIdentifierResponse
    {
        [JsonPropertyName("entityType")]
        public int EntityType { get; set; }

        [JsonPropertyName("identifier")]
        public string Identifier { get; set; }
    }
}
