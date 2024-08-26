using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class BankResponse
    {
        [JsonPropertyName("bankGroup")]
        public BankGroupResponse BankGroup { get; set; }

        [JsonPropertyName("bankId")]
        public int BankId { get; set; }

        [JsonPropertyName("briefName")]
        public string BriefName { get; set; }

        [JsonPropertyName("contactPhoneMoscow")]
        public string ContactPhoneMoscow { get; set; }

        [JsonPropertyName("contactPhoneRussia")]
        public string ContactPhoneRussia { get; set; }

        [JsonPropertyName("bic")]
        public string Bic { get; set; }

        [JsonPropertyName("inn")]
        public string Inn { get; set; }

        [JsonPropertyName("displayMember")]
        public string DisplayMember { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("correspondenceAccount")]
        public string CorrespondenceAccount { get; set; }

        [JsonPropertyName("bankType")]
        public int BankType { get; set; }

        [JsonPropertyName("kpp")]
        public string Kpp { get; set; }

        [JsonPropertyName("imageSrc")]
        public string ImageSrc { get; set; }
    }
}
