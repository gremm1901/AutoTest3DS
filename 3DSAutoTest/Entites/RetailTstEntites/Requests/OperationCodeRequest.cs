using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.requests
{
    public class OperationCodeRequest
    {
        [JsonPropertyName("operationCode")]
        public int OperationCode { get; set; }
    }
}
