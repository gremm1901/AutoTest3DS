using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class DictionaryResponse
    {
        [JsonPropertyName("dictItems")]
        public List<DictItemResponse> DictItems { get; set; }

        [JsonPropertyName("isStrict")]
        public bool? IsStrict { get; set; }
    }
}
