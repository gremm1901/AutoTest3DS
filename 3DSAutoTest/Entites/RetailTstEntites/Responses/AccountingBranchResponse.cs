using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class AccountingBranchResponse
    {
        [JsonPropertyName("branchId")]
        public int BranchId { get; set; }

        [JsonPropertyName("briefName")]
        public string BriefName { get; set; }

        [JsonPropertyName("bic")]
        public string Bic { get; set; }

        [JsonPropertyName("corrAccount")]
        public string CorrAccount { get; set; }

        [JsonPropertyName("bank")]
        public BankResponse Bank { get; set; }
    }
}
