using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class StartOperatonResponse
    {
        [JsonPropertyName("caption")]
        public string Caption { get; set; }

        [JsonPropertyName("params")]
        public List<ParamResponse> Params { get; set; }

        [JsonPropertyName("stepClass")]
        public string StepClass { get; set; }

        [JsonPropertyName("requestId")]
        public long RequestId { get; set; }

        [JsonPropertyName("messages")]
        public List<object> Messages { get; set; }

        [JsonPropertyName("operation")]
        public OperationResponse Operation { get; set; }

        [JsonPropertyName("stepId")]
        public int StepId { get; set; }

        [JsonPropertyName("groups")]
        public List<object> Groups { get; set; }

        [JsonPropertyName("popups")]
        public List<object> Popups { get; set; }

        [JsonPropertyName("customData")]
        public List<object> CustomData { get; set; }

        [JsonPropertyName("googleAnalyticParams")]
        public List<object> GoogleAnalyticParams { get; set; }
    }
}
