using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class LoyaltyProductResponse
    {
        [JsonPropertyName("productType")]
        public int ProductType { get; set; }

        [JsonPropertyName("loyaltyPackage")]
        public LoyaltyPackageResponse LoyaltyPackage { get; set; }

        [JsonPropertyName("frontPattern")]
        public int FrontPattern { get; set; }
    }
}
