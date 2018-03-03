using Newtonsoft.Json;

namespace LiqPay.Models.Responses.Acquiring
{
    public class UnsubscribeLiqPayResponseModel : AcquirerLiqPayResponseModel
    {
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("card_token")]
        public string CardToken { get; set; }
    }
}
