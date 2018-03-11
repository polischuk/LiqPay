using Newtonsoft.Json;

namespace LiqPay.Models.Requests
{
    public class Verify3DsLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("token", NullValueHandling = NullValueHandling.Ignore)]
        public string Token { get; set; }
    }
}
