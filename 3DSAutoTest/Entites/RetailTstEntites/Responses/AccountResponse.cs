using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class AccountResponse
    {
        [JsonPropertyName("cardAccountId")]
        public int CardAccountId { get; set; }

        [JsonPropertyName("mainCreditLimit")]
        public int MainCreditLimit { get; set; }

        [JsonPropertyName("isOwner")]
        public bool IsOwner { get; set; }

        [JsonPropertyName("programType")]
        public ProgramTypeResponse ProgramType { get; set; }

        [JsonPropertyName("accountType")]
        public int AccountType { get; set; }

        [JsonPropertyName("tariffNameIndex")]
        public string TariffNameIndex { get; set; }

        [JsonPropertyName("currency")]
        public CurrencyResponse Currency { get; set; }

        [JsonPropertyName("office")]
        public OfficeResponse Office { get; set; }

        [JsonPropertyName("accountingBranch")]
        public AccountingBranchResponse AccountingBranch { get; set; }

        [JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("balance")]
        public int Balance { get; set; }

        [JsonPropertyName("availableBalance")]
        public int AvailableBalance { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("entityIdentifier")]
        public EntityIdentifierResponse EntityIdentifier { get; set; }
    }
}
