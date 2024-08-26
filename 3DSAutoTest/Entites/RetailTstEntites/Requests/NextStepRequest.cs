using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.requests
{
    public class NextStepRequest
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        [JsonPropertyName("postBackParamIdentifier")]
        public object PostBackParamIdentifier { get; set; }

        [JsonPropertyName("params")]
        public List<ParamRequest> Params { get; set; }
    }
}
