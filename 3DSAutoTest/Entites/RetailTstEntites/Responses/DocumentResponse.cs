using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class DocumentResponse
    {
        [JsonPropertyName("identifier")]
        public IdentifierResponse Identifier { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    
}
