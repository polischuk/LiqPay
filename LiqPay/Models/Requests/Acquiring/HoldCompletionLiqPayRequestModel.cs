using Newtonsoft.Json;

namespace LiqPay.Models.Requests.Acquiring
{
    public class HoldCompletionLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
