using Newtonsoft.Json;

namespace LiqPay.Models.Requests
{
    public class OtpVerifyLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("otp")]
        public string Otp { get; set; }
    }
}
