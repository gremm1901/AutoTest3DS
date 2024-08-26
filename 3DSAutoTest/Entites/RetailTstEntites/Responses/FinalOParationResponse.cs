using AngleSharp.Io;
using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class FinalOParationResponse
    {
        [JsonPropertyName("request")]
        public Request Request { get; set; }

        [JsonPropertyName("finalParams")]
        public List<FinalParamResponse> FinalParams { get; set; }
    }
}
