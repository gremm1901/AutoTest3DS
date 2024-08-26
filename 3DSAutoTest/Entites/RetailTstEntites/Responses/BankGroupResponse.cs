using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class BankGroupResponse
    {
        [JsonPropertyName("bankGroupId")]
        public int BankGroupId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
