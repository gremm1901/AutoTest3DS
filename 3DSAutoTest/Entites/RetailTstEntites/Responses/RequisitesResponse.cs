using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class RequisitesResponse
    {
        [JsonPropertyName("bank")]
        public BankResponse Bank { get; set; }

        [JsonPropertyName("accountingBankName")]
        public string AccountingBankName { get; set; }

        [JsonPropertyName("beneficiaryName")]
        public string BeneficiaryName { get; set; }
    }
}
