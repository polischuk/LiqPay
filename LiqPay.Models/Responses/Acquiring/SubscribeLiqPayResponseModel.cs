using Newtonsoft.Json;

namespace LiqPay.Models.Responses.Acquiring
{
    public class SubscribeLiqPayResponseModel : AcquirerLiqPayResponseModel
    {
        [JsonProperty("redirect_to")]
        public string RedirectTo { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("card_token")]
        public string CardToken { get; set; }
    }
}
