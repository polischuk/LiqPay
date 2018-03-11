using Newtonsoft.Json;

namespace LiqPay.Models.Responses
{
    public class CallbackResponseModel : BaseLiqPayResponseModel
    {
        [JsonProperty("redirect_to")]
        public string RedirectTo { get; set; }
        [JsonProperty("token")]
        public string Token { get; set; }
        [JsonProperty("card_token")]
        public string CardToken { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
