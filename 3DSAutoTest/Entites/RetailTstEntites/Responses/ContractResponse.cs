using AngleSharp.Io;
using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class ContractResponse
    {
        [JsonPropertyName("contractId")]
        public int ContractId { get; set; }

        [JsonPropertyName("brand")]
        public BrandResponse Brand { get; set; }

        [JsonPropertyName("request")]
        public Request Request { get; set; }

        [JsonPropertyName("office")]
        public OfficeResponse Office { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("beginDate")]
        public DateTime BeginDate { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("entityIdentifier")]
        public EntityIdentifierResponse EntityIdentifier { get; set; }
    }
}
