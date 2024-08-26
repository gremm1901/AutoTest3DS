using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class CardResponse
    {
        [JsonPropertyName("cardId")]
        public int CardId { get; set; }

        [JsonPropertyName("account")]
        public AccountResponse Account { get; set; }

        [JsonPropertyName("cardNumber")]
        public string CardNumber { get; set; }

        [JsonPropertyName("state")]
        public int State { get; set; }

        [JsonPropertyName("isDigital")]
        public bool IsDigital { get; set; }

        [JsonPropertyName("isMadeWithoutPinCode")]
        public bool IsMadeWithoutPinCode { get; set; }

        [JsonPropertyName("pinCodeStatus")]
        public int PinCodeStatus { get; set; }

        [JsonPropertyName("changePinCodeStatus")]
        public int ChangePinCodeStatus { get; set; }

        [JsonPropertyName("pinCodeLaunchOperationAllowed")]
        public bool PinCodeLaunchOperationAllowed { get; set; }

        [JsonPropertyName("smallImageSrc")]
        public string SmallImageSrc { get; set; }

        [JsonPropertyName("largeImageSrc")]
        public string LargeImageSrc { get; set; }

        [JsonPropertyName("themeColor")]
        public string ThemeColor { get; set; }

        [JsonPropertyName("is3DSecureActive")]
        public bool Is3DSecureActive { get; set; }

        [JsonPropertyName("isOwner")]
        public bool IsOwner { get; set; }

        [JsonPropertyName("expireDate")]
        public DateTime ExpireDate { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("type")]
        public int Type { get; set; }

        [JsonPropertyName("productTariffUrl")]
        public string ProductTariffUrl { get; set; }

        [JsonPropertyName("fee")]
        public FeeResponse Fee { get; set; }

        [JsonPropertyName("smsFee")]
        public SmsFeeResponse SmsFee { get; set; }

        [JsonPropertyName("cardProduct")]
        public CardProductResponse CardProduct { get; set; }

        [JsonPropertyName("entityIdentifier")]
        public EntityIdentifierResponse EntityIdentifier { get; set; }

        [JsonPropertyName("tariffNameIndex")]
        public string TariffNameIndex { get; set; }

        [JsonPropertyName("isReissueAllowed")]
        public bool IsReissueAllowed { get; set; }

        [JsonPropertyName("isPlasticProductionAllowed")]
        public bool IsPlasticProductionAllowed { get; set; }

        [JsonPropertyName("isAddCardOrderAllowed")]
        public bool IsAddCardOrderAllowed { get; set; }

        [JsonPropertyName("embossingName")]
        public string EmbossingName { get; set; }

        [JsonPropertyName("financialGroup")]
        public FinancialGroupResponse FinancialGroup { get; set; }

        [JsonPropertyName("isCardSignificantDataAllowed")]
        public bool IsCardSignificantDataAllowed { get; set; }

        [JsonPropertyName("loyaltyProduct")]
        public LoyaltyProductResponse LoyaltyProduct { get; set; }

        [JsonPropertyName("isDocumentsInformationAvailable")]
        public bool IsDocumentsInformationAvailable { get; set; }

        [JsonPropertyName("isCardWorkModalDisplayed")]
        public bool IsCardWorkModalDisplayed { get; set; }

        [JsonPropertyName("isCardCloseEnabled")]
        public bool IsCardCloseEnabled { get; set; }
    }
}
