using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class OfficeResponse
    {
        [JsonPropertyName("officeId")]
        public int OfficeId { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("briefName")]
        public string BriefName { get; set; }

        [JsonPropertyName("branch")]
        public BranchResponse Branch { get; set; }

        [JsonPropertyName("address")]
        public string Address { get; set; }

        [JsonPropertyName("contactLocality")]
        public string ContactLocality { get; set; }

        [JsonPropertyName("streetLocation")]
        public string StreetLocation { get; set; }

        [JsonPropertyName("metro")]
        public string Metro { get; set; }

        [JsonPropertyName("geoLat")]
        public double GeoLat { get; set; }

        [JsonPropertyName("geoLong")]
        public double GeoLong { get; set; }
    }
}
