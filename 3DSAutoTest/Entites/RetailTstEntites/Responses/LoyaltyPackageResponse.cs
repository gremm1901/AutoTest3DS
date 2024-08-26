using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class LoyaltyPackageResponse
    {
        [JsonPropertyName("productType")]
        public int ProductType { get; set; }

        [JsonPropertyName("categories")]
        public List<CategoryResponse> Categories { get; set; }
    }
}
