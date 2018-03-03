using Newtonsoft.Json;

namespace LiqPay.Models.Requests
{
    public class P2PCreditLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("currency")]
        public string Currency { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
        [JsonProperty("receiver_card")]
        public string ReceiverCard { get; set; }
        [JsonProperty("ip")]
        public string Ip { get; set; }
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }
        [JsonProperty("sandbox", NullValueHandling = NullValueHandling.Ignore)]
        public string Sandbox { get; set; }
        [JsonProperty("server_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ServerUrl { get; set; }
        [JsonProperty(PropertyName = "receiver_card_token", NullValueHandling = NullValueHandling.Ignore)]
        public string ReceiverCardToken { get; set; }
       
    }
}
