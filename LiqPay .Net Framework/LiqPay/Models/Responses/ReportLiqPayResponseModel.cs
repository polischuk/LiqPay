using Newtonsoft.Json;

namespace LiqPay.Models.Responses
{
    public class ReportLiqPayResponseModel: BaseLiqPayResponseModel
    {
        [JsonProperty("status")]
        public string Status { get; set; }
        [JsonProperty("type")]
        public string PaymentType { get; set; }
        [JsonProperty("token")]
        public string PaymentToken { get; set; }
        [JsonProperty("card_token")]
        public string CardToken { get; set; }
        [JsonProperty("payment_id")]
        public string PaymentId { get; set; }
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
        [JsonProperty("amount")]
        public string Amount { get; set; }
        [JsonProperty("agent_commission")]
        public string Commission { get; set; }
    }
}
