using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class DataScoreResponse
    {
        [JsonPropertyName("minBalance")]
        public int MinBalance { get; set; }

        [JsonPropertyName("isAccountClosureAvailable")]
        public bool IsAccountClosureAvailable { get; set; }

        [JsonPropertyName("conditionsHint")]
        public string ConditionsHint { get; set; }

        [JsonPropertyName("accountId")]
        public int AccountId { get; set; }

        [JsonPropertyName("contract")]
        public ContractResponse Contract { get; set; }

        [JsonPropertyName("accountType")]
        public int AccountType { get; set; }

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

        [JsonPropertyName("clientLabel")]
        public string ClientLabel { get; set; }

        [JsonPropertyName("balance")]
        public int Balance { get; set; }

        [JsonPropertyName("availableBalance")]
        public int AvailableBalance { get; set; }

        [JsonPropertyName("isWithReplenishment")]
        public bool IsWithReplenishment { get; set; }

        [JsonPropertyName("isWithSubtraction")]
        public bool IsWithSubtraction { get; set; }

        [JsonPropertyName("openDate")]
        public DateTime OpenDate { get; set; }

        [JsonPropertyName("status")]
        public int Status { get; set; }

        [JsonPropertyName("requisites")]
        public RequisitesResponse Requisites { get; set; }

        [JsonPropertyName("entityIdentifier")]
        public EntityIdentifierResponse EntityIdentifier { get; set; }
    }
}
