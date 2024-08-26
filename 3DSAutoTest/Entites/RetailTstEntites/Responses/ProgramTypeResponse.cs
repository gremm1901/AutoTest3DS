using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class ProgramTypeResponse
    {
        [JsonPropertyName("programTypeId")]
        public int ProgramTypeId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
