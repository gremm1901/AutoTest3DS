using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class NextStepResponse
    {
        [JsonPropertyName("caption")]
        public string Caption { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("params")]
        public List<ParamResponse> Params { get; set; }

        [JsonPropertyName("stepClass")]
        public string StepClass { get; set; }

        [JsonPropertyName("requestId")]
        public long RequestId { get; set; }

        [JsonPropertyName("hasPreviousStep")]
        public bool HasPreviousStep { get; set; }

        [JsonPropertyName("skipConfirmStep")]
        public bool SkipConfirmStep { get; set; }

        [JsonPropertyName("messages")]
        public List<object> Messages { get; set; }

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
