using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class CardProductResponse
    {
        [JsonPropertyName("cardProductId")]
        public int CardProductId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("isEWalletAvailable")]
        public bool IsEWalletAvailable { get; set; }
    }
}
