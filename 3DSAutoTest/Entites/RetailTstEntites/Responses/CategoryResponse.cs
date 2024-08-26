using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class CategoryResponse
    {
        [JsonPropertyName("categoryId")]
        public int CategoryId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("remunerationInterestDetails")]
        public List<RemunerationInterestDetailResponse> RemunerationInterestDetails { get; set; }

        [JsonPropertyName("iconCode")]
        public int IconCode { get; set; }

        [JsonPropertyName("iconUrl")]
        public string IconUrl { get; set; }

        [JsonPropertyName("isOtherMcc")]
        public bool? IsOtherMcc { get; set; }
    }
}
