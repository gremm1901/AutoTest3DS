using System.Diagnostics.Contracts;
using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class CurrencyResponse
    {
        [JsonPropertyName("currencyId")]
        public int CurrencyId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("nameIso")]
        public string NameIso { get; set; }
    }
}
