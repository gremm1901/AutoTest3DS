using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class NextTwoStepResponse
    {
        [JsonPropertyName("requestId")]
        public long RequestId { get; set; }

        [JsonPropertyName("isFinished")]
        public bool IsFinished { get; set; }

        [JsonPropertyName("hasPreviousStep")]
        public bool HasPreviousStep { get; set; }

        [JsonPropertyName("messages")]
        public List<object> Messages { get; set; }

        [JsonPropertyName("googleAnalyticParams")]
        public List<object> GoogleAnalyticParams { get; set; }
    }
}
