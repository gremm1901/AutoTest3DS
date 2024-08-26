using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class GraceResponse
    {
        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("ownAmount")]
        public int OwnAmount { get; set; }

        [JsonPropertyName("firstDueDate")]
        public DateTime FirstDueDate { get; set; }

        [JsonPropertyName("graceAmount")]
        public int GraceAmount { get; set; }

        [JsonPropertyName("availableOwnAmount")]
        public int AvailableOwnAmount { get; set; }
    }
}
