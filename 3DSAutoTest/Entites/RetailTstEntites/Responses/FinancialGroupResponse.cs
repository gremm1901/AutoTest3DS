using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class FinancialGroupResponse
    {
        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
