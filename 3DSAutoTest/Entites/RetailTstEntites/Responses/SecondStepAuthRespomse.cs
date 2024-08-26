using System.Text.Json.Serialization;

namespace _3DSAutoTest.Entites.RetailTstEntites.responses
{
    public class SecondStepAuthRespomse
    {
        [JsonPropertyName("usedChannel")]
        public int UsedChannel { get; set; }

        [JsonPropertyName("smsChannelStatus")]
        public int SmsChannelStatus { get; set; }

        [JsonPropertyName("pushChannelStatus")]
        public int PushChannelStatus { get; set; }

        [JsonPropertyName("otpChannelStatus")]
        public int OtpChannelStatus { get; set; }

        [JsonPropertyName("smsData")]
        public SmsDataRespomse SmsData { get; set; }

        [JsonPropertyName("otpData")]
        public OtpDataResRespomse OtpData { get; set; }
    }
}
