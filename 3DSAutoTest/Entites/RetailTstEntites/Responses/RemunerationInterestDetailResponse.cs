using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class RemunerationInterestDetailResponse
    {
        [JsonPropertyName("remunerationInterest")]
        public double RemunerationInterest { get; set; }

        [JsonPropertyName("amountFrom")]
        public int AmountFrom { get; set; }

        [JsonPropertyName("goalReached")]
        public bool GoalReached { get; set; }
    }
}
