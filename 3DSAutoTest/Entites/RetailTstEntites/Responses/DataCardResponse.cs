using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class DataCardResponse
    {
        [JsonPropertyName("cardAccountId")]
        public int CardAccountId { get; set; }

        [JsonPropertyName("cards")]
        public List<CardResponse> Cards { get; set; }

        [JsonPropertyName("mainCreditLimit")]
        public int MainCreditLimit { get; set; }

        [JsonPropertyName("grace")]
        public GraceResponse Grace { get; set; }

        [JsonPropertyName("isOwner")]
        public bool IsOwner { get; set; }

        [JsonPropertyName("allCardsCount")]
        public int AllCardsCount { get; set; }

        [JsonPropertyName("programType")]
        public ProgramTypeResponse ProgramType { get; set; }

        [JsonPropertyName("accountType")]
        public int AccountType { get; set; }

        [JsonPropertyName("tariffNameIndex")]
        public string TariffNameIndex { get; set; }

        [JsonPropertyName("isAddVirtualMirCardAvailable")]
        public bool IsAddVirtualMirCardAvailable { get; set; }

        [JsonPropertyName("openwayContractNumber")]
        public string OpenwayContractNumber { get; set; }

        [JsonPropertyName("loyaltyProduct")]
        public LoyaltyProductResponse LoyaltyProduct { get; set; }

        [JsonPropertyName("marketProductCode")]
        public string MarketProductCode { get; set; }

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

        [JsonPropertyName("requisites")]
        public RequisitesResponse Requisites { get; set; }

        [JsonPropertyName("entityIdentifier")]
        public EntityIdentifierResponse EntityIdentifier { get; set; }
    }
}
