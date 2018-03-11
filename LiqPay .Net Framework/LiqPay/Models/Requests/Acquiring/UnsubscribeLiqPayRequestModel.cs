using Newtonsoft.Json;

namespace LiqPay.Models.Requests.Acquiring
{
    public class UnsubscribeLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
