using Newtonsoft.Json;

namespace LiqPay.Models.Responses
{
    public class StatusLiqPayResponseModel : BasePaymentLiqPayResponseModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("card_token")]
        public string CardToken { get; set; }
    }
}
