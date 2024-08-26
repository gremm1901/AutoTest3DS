using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class RequestResponse
    {
        [JsonPropertyName("requestId")]
        public long RequestId { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("office")]
        public OfficeResponse Office { get; set; }

        [JsonPropertyName("operation")]
        public OperationResponse Operation { get; set; }

        [JsonPropertyName("startTime")]
        public DateTime StartTime { get; set; }

        [JsonPropertyName("requestTime")]
        public DateTime RequestTime { get; set; }

        [JsonPropertyName("mode")]
        public int Mode { get; set; }

        [JsonPropertyName("sum")]
        public double Sum { get; set; }

        [JsonPropertyName("currency")]
        public CurrencyResponse Currency { get; set; }

        [JsonPropertyName("commissionSum")]
        public double CommissionSum { get; set; }

        [JsonPropertyName("isRepeatAllowed")]
        public bool IsRepeatAllowed { get; set; }

        [JsonPropertyName("stateName")]
        public string StateName { get; set; }

        [JsonPropertyName("documents")]
        public List<DocumentResponse> Documents { get; set; }
    }
}
