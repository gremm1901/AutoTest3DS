using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class ValueResponse
    {
        [JsonPropertyName("min")]
        public object Min { get; set; }

        [JsonPropertyName("max")]
        public object Max { get; set; }

        [JsonPropertyName("decimals")]
        public int Decimals { get; set; }

        [JsonPropertyName("typeCode")]
        public int TypeCode { get; set; }

        [JsonPropertyName("dictionary")]
        public DictionaryResponse Dictionary { get; set; }

        [JsonPropertyName("expectedValue")]
        public string ExpectedValue { get; set; }

        [JsonPropertyName("inputMask")]
        public string InputMask { get; set; }

        [JsonPropertyName("validCharsets")]
        public int? ValidCharsets { get; set; }

        [JsonPropertyName("mayBeNull")]
        public bool? MayBeNull { get; set; }

        [JsonPropertyName("value")]
        public object Value { get; set; }

        [JsonPropertyName("trueCaption")]
        public string TrueCaption { get; set; }

        [JsonPropertyName("falseCaption")]
        public string FalseCaption { get; set; }
    }
}
