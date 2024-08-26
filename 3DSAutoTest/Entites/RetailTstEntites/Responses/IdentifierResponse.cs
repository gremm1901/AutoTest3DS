using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class IdentifierResponse
    {
        [JsonPropertyName("requestId")]
        public object RequestId { get; set; }

        [JsonPropertyName("taskId")]
        public string TaskId { get; set; }

        [JsonPropertyName("taskTypeId")]
        public int TaskTypeId { get; set; }

        [JsonPropertyName("documentId")]
        public int DocumentId { get; set; }
    }

    
}
