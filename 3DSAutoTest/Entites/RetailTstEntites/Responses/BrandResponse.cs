using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class BrandResponse
    {
        [JsonPropertyName("brandId")]
        public int BrandId { get; set; }
    }
}
