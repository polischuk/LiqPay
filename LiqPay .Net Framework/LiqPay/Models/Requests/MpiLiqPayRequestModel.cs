using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace LiqPay.Models.Requests
{
    public class MpiLiqPayRequestModel : BaseLiqPayRequestModel
    {
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
        public string Phone { get; set; }
        [JsonProperty("amount")]
        public decimal Amount { get; set; }
        [JsonProperty("currency")]
        [JsonConverter(typeof(StringEnumConverter))]
        public Currency Currency { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("card")]
        public string Card { get; set; }
        [JsonProperty("card_exp_month")]
        public string CardExpMonth { get; set; }
        [JsonProperty("card_exp_year")]
        public string CardExpYear { get; set; }
        [JsonProperty("card_cvv")]
        public string CardCvv { get; set; }
        [JsonProperty("ip")]
        public string Ip { get; set; }
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }
        [JsonProperty("mpi_action", NullValueHandling = NullValueHandling.Ignore)]
        public string MpiAction { get; set; }
    }
}
