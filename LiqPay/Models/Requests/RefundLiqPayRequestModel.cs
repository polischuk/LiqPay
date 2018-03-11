using Newtonsoft.Json;

namespace LiqPay.Models.Requests
{
    public class RefundLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
    }
}
