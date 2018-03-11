using Newtonsoft.Json;

namespace LiqPay.Models.Responses
{
    public class AuthLiqPayResponseModel: BasePaymentLiqPayResponseModel
    {
        [JsonProperty("redirect_to")]
        public string RedirectTo { get; set; }

        [JsonProperty("token")]
        public string Token { get; set; }

        [JsonProperty("card_token")]
        public string CardToken { get; set; }
    }
}
