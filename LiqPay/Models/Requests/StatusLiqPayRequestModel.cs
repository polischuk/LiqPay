using Newtonsoft.Json;

namespace LiqPay.Models.Requests
{
    public class StatusLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
