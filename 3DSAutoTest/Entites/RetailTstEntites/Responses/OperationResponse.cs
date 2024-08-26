using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class OperationResponse
    {
        [JsonPropertyName("operationId")]
        public int OperationId { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("help")]
        public HelpResponse Help { get; set; }

        [JsonPropertyName("imageSrc")]
        public string ImageSrc { get; set; }

        [JsonPropertyName("isTemplateSupported")]
        public bool IsTemplateSupported { get; set; }

        [JsonPropertyName("confirmButtonText")]
        public string ConfirmButtonText { get; set; }
    }
}
